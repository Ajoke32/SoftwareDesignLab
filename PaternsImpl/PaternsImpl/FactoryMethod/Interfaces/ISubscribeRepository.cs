using PaternsImpl.FactoryMethod.Classes;
using PaternsImpl.FactoryMethod.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Interfaces
{
    internal interface ISubscribeRepository
    {
        public List<ISubscribe>? GetSubscribesBySubscribeId(int id);
        public bool AddSubscibe(ISubscribe subscribe,User user);
        public ISubscribe? GetSubscribeById(int id);

        public ISubscribe? GetSubscribeByOwnerId(int id);

        public List<ISubscribe> GetAll();
    }
}
