using PaternsImpl.FactoryMethod.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Interfaces
{
    internal interface ISubscribeManager
    {
        public bool BuySubscribtion(int subId, User sender);

        public bool Unsubscribe(int subId, User sender);

       /* public string GetAllSubscribtions();

        public List<ISubscribe>? GetSubscribes(int id);

        public string GetExpirationDate(int id, User user);*/
    }
}
