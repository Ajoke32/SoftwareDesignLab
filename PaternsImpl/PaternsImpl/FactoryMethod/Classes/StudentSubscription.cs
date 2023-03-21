using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Classes
{
    internal class StudentSubscription : ISubscribe
    {
        public int Id { get; set; }

        public decimal MonthPrice { get; set; }

        public List<Chanel>? Chanels { get; set; }

        public DateTime Expiration { get; set; }
        public string? Description { get; set; }

        public int MinPeriodDays => 15;

        public User? Owner { get ; set; }

    }
}
