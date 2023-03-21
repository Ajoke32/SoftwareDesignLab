using Microsoft.VisualBasic;
using PaternsImpl.FactoryMethod.CustomEventArgs;
using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using PaternsImpl.FactoryMethod.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaternsImpl.FactoryMethod.Classes
{
    internal delegate void SubscriptionEventHandler(User sender, SubscriptionEventArgs e);

    internal delegate bool SubcriptionListEventHandler(User sender, SubscriptionEventArgs e);
    internal class SubsсriptionManager : ISubscribeManager
    {
        public event SubscriptionEventHandler? OnSubscribe=null;
        public event SubscriptionEventHandler? OnUsubscribe=null;
        public event SubcriptionListEventHandler? GettingSubscribe=null;
        public event SubscriptionEventHandler? ExpiratioGetting = null;

        ISubscribeRepository _repo;
        SubscribeFactory _factory;
        public SubsсriptionManager(ISubscribeRepository repo)
        {
            _repo = repo;
            _factory = new SubscribeFactory();
   
        }
        public bool BuySubscribtion(int subId,User sender)
        {
            var subs = _repo.GetSubscribesBySubscribeId(sender.Id);
            if(subs== null)
            {
                return false;
            }
            var sub = subs.FirstOrDefault(s=>s.Id==subId);

            if (sub != null&&sub.Id==subId)
            {
                sub.Expiration = sub.Expiration.AddDays(sub.MinPeriodDays);
                OnSubscribe?.Invoke(sender, new SubscriptionEventArgs() {StatusCode=2,Subscribe=sub});
                return false;
            }
            var factorySub = _factory.CreateSubscribe(subId);
            _repo.AddSubscibe(factorySub, sender);
            OnSubscribe?.Invoke(sender, new SubscriptionEventArgs() { StatusCode=1,Subscribe=factorySub});
            return true;
        }
        
        public bool Unsubscribe(int subId, User sender)
        {
            var subs = _repo.GetSubscribesBySubscribeId(sender.Id);
            if (subs == null)
            {
                return false;
            }
            var sab = subs.FirstOrDefault(s => s.Id == subId);

            if (sab == null)
            {
                OnUsubscribe?.Invoke(sender,new SubscriptionEventArgs() { StatusCode = 2,Subscribe=_factory.CreateSubscribe(subId)});
                return false;
            }
            var ex = DateAndTime.DateDiff(DateInterval.Day, DateTime.Now, sab.Expiration);

            if (ex >= sab.MinPeriodDays)
            {
                sab.Expiration = sab.Expiration.AddDays(-sab.MinPeriodDays);

                OnUsubscribe?.Invoke(sender, new SubscriptionEventArgs() {StatusCode=1,Subscribe=sab});
                return true;
            }

            OnUsubscribe?.Invoke(sender, new SubscriptionEventArgs() {StatusCode=3, Subscribe = _factory.CreateSubscribe(subId) });
            return false;
        }
        public List<ISubscribe> GetSubscribes()
        {
            return _repo.GetAll();
        }
        public bool GetUserSubscriptions(User user)
        {
            var subscribes = _repo.GetSubscribesBySubscribeId(user.Id);

            if (subscribes != null)
            {
                GettingSubscribe?.Invoke(user,new SubscriptionEventArgs() { StatusCode=100,Subscriptions=subscribes});

                return true;
            }

            GettingSubscribe?.Invoke(user,new SubscriptionEventArgs() { StatusCode=101});
            return true;
         
        }

        public bool GetSubscriptionExpirationDay(User user,int subId)
        {
            var subs = _repo.GetSubscribesBySubscribeId(user.Id);
            if (subs == null || subs.Count == 0)
            {
                ExpiratioGetting?.Invoke(user,new SubscriptionEventArgs() { StatusCode=2,Message="You not have subscriptions"});
                return false;
            }
            var sub = subs.FirstOrDefault(s => s.Id == subId);
            ExpiratioGetting?.Invoke(user, new SubscriptionEventArgs() { StatusCode = 1, Subscribe=sub });
            return true;
        }

    }
}
