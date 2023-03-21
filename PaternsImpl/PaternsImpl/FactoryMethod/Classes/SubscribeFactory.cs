using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Classes
{
    internal class SubscribeFactory
    {
        
 
        public ISubscribe CreateSubscribe(int id)
        {
            switch (id)
            {
                case 1:
                {
                        var subscribe = new DomesticSubscription() { Id = 1, Description = "Domestic",Expiration = DateTime.Now ,MonthPrice = 300 };
                        AddDays(subscribe);
                        return subscribe;
                }
                case 2:
                {
                        var subscribe = new StudentSubscription() { Id = 2, Description = "Student",Expiration=DateTime.Now};
                        AddDays(subscribe);
                        return subscribe;
                }
                case 3:
                {
                        var subscribe = new PremiumSubscription() { Id = 3, Description = "Pemium", Expiration = DateTime.Now, MonthPrice = 300 };
                        AddDays(subscribe);
                        return subscribe;
                }
                default: throw new ArgumentException("Invalid subscribtion id");
            }
        }
        private void AddDays(ISubscribe subscribe)
        {
            subscribe.Expiration = subscribe.Expiration.AddDays(subscribe.MinPeriodDays);
        }
    }

}
