using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Classes
{
    internal class DomesticSubscription : ISubscribe

    {
        private decimal price=300;
        public int Id { get; set; }

        public decimal MonthPrice { get=>price; set {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        public List<Chanel>? Chanels { get; set ; }

        public DateTime Expiration { get; set; }
        public string Description { get ; set; }

        public int MinPeriodDays => 30;


        public User Owner { get; set ; }

    }
}
