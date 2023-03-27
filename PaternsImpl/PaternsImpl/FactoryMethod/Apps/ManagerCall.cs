using PaternsImpl.FactoryMethod.CustomEventArgs;
using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using PaternsImpl.FactoryMethod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Apps
{
 
    internal class ManagerCall : IApplication
    {
        private SubsсriptionManager _manager;
        private User? _user = null;
        
        public ManagerCall(ISubscribeManager manager)
        {
            _manager = (SubsсriptionManager)manager;
            _manager.OnSubscribe += BuySubscription;
            _manager.OnUsubscribe += CancelSubscribe;
            _manager.GettingSubscribe += DisplayUserSubscriptionList;
            _manager.ExpiratioGetting += DisplaySubscriptionExpirationDate;
        }

        public void Run()
        {
            Console.WriteLine("Manager Call.......");
        }
        
        private void BuySubscription(User sender, SubscriptionEventArgs e)
        {
            if (e.StatusCode == 1)
            {
                Console.WriteLine($"You are subscribed on {e.Subscribe?.Description} subscription, expiration date is {e.Subscribe?.Expiration}\n" +
                    $"You can check any details on you messages");
            }
            if (e.StatusCode == 2)
            {
                Console.WriteLine($"Subscription extended on {e.Subscribe?.MinPeriodDays}, expiration date is {e.Subscribe?.Expiration}");
            }
        }
        private void CancelSubscribe(User sender, SubscriptionEventArgs e)
        {
            if (e.StatusCode == 1)
            {
                Console.WriteLine($"Subscription cancelled, expiration date is {e.Subscribe?.Expiration}");
            }
            if (e.StatusCode == 3)
            {
                Console.WriteLine($"You cannot cancel it, min period days is {e.Subscribe?.MinPeriodDays}");
            }
            if (e.StatusCode == 2)
            {
                Console.WriteLine($"You are not subscribed on {e.Subscribe?.Description} subscription");
            }
        }

        public void InitUser(User user)
        {
            _user = user;
        }
        private bool DisplayUserSubscriptionList(User sender, SubscriptionEventArgs e)
        {
            if (e.StatusCode != 100)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            foreach (var item in e.Subscriptions)
            {
                Console.WriteLine($"Name: {item.Description}\nExpire on:{item.Expiration}\nMonth price: {item.MonthPrice}" +
                    $"\nMin period:{item.MinPeriodDays}");
            }
            return true;
        }

        private bool EmailConfirmation()
        {
            Console.Write("Enter email:");
            var email = Console.ReadLine();
            if (email.Contains("student") || email.Contains("edu"))
            {
                return true;
            }
            return false;
        }
        private int SelectSubscription()
        {
            Console.Write("Enter subscription number: ");
            var subid = Console.ReadLine();
            if (subid == null)
            {
                return -1;
            }
            if (int.Parse(subid) == 2 && !EmailConfirmation())
            {
                return -1;
            }
            return int.Parse(subid);
        }
        private void DisplaySubscriptionExpirationDate(User sender, SubscriptionEventArgs e)
        {
            if (e.StatusCode == 1)
            {
                Console.WriteLine($"Expiration date for {e.Subscribe.Description} is {e.Subscribe.Expiration}");

            }
            if (e.StatusCode == 2)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void PrintSubscribes()
        {
            
            var subs = _manager.GetSubscribes();
            foreach(var sub in subs)
            {
                Console.WriteLine($"{sub.Description} {sub.MonthPrice}$");
            }
        }


        public void ShowInterface()
        {

            if (_user == null)
            {
                throw new Exception("User is not set");
            }

            Console.WriteLine("1.Subscription list 2.Buy Subscrition 3.Unsubscribe 4.Display my subscriptions 5.Display subscription expiration date");

            while (true)
            {
                var s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        PrintSubscribes();
                        break;
                    case "2":
                        _manager.BuySubscribtion(SelectSubscription(), _user);
                        break;
                    case "3":
                        _manager.Unsubscribe(SelectSubscription(), _user);
                        break;
                    case "4":
                        _manager.GetUserSubscriptions(_user);
                        break;
                    case "5":
                        _manager.GetSubscriptionExpirationDay(_user, SelectSubscription());
                        break;
                    default: return;
                }

            }

        }
    }
}
