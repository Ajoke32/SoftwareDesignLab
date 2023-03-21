using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Classes
{
    internal class PremiumSubscription : ISubscribe
    {
        public int Id { get ; set ; }
        public decimal MonthPrice { get; set; }
        public List<Chanel> Chanels { get; set; }
        public DateTime Expiration { get; set; }

        public int MinPeriodDays => 10;

        public string Description { get; set; }
        public User Owner { get ; set ; }
    }
}
