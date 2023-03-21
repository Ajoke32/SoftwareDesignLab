using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.CustomEventArgs
{
    internal class SubscriptionEventArgs:EventArgs
    {
       
        public ISubscribe? Subscribe { get; set; }
        
        public int StatusCode { get; set; }

        public List<ISubscribe>? Subscriptions { get; set; }

        public string? Message { get; set; }

    }
}
