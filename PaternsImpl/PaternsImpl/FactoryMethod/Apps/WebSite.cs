using Microsoft.VisualBasic;
using PaternsImpl.FactoryMethod.Classes;
using PaternsImpl.FactoryMethod.CustomEventArgs;
using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using PaternsImpl.FactoryMethod.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Apps
{
    /// <summary>
    /// важко зробити щось інше в цих класах, окрім інтефейсних відмінностей відображення в консолі, тому що немає готової архітектури додатку
    /// а як її писати самому я не знаю.
    /// якщо це веб додаток, то дані приходилиб з форми, але як це показати тут - я не знаю
    /// Тому тут просто копіпаст
    /// </summary>
    internal class WebSite : IApplication
    {
        public int Port { get; set; } = 3000;

        private ISubscribeManager _manager;

        private User? _user;
        public WebSite(ISubscribeManager manager)
        {
            _manager = manager;
        }

        public void Run()
        {
            Console.WriteLine($"Website listened on port {Port}");
        }
        /*
        private void BuySubscription(User sender, SubscriptionEventArgs e)
        {
            Console.WriteLine("----------------------Purchase result----------------------");
            if (e.StatusCode == 1)
            {
                Console.WriteLine($"You are subscribed on {e.Subscribe?.Description} subscription\n expiration date is {e.Subscribe?.Expiration}");
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
        */
    }

}
