using PaternsImpl.FactoryMethod.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Interfaces
{
    internal interface ISubscribe
    {
        public int Id { get; set; }

        public decimal MonthPrice { get; set; }

        public List<Chanel> Chanels { get; set; }

        public DateTime Expiration { get; set; }

        public int MinPeriodDays { get; }

        public string Description { get; set; }

        public  User Owner {get;set;}
    }
}
