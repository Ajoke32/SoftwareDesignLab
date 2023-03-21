using PaternsImpl.FactoryMethod.Classes;
using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Repositories
{
    internal class SubscribeRepository : ISubscribeRepository
    {
        private Store _store;
        public SubscribeRepository(Store store) 
        {
            _store = store;
        }
        public bool AddSubscibe(ISubscribe subscribe, User user)
        {
            subscribe.Owner = user;
            _store.UsersSubscribes.Add(subscribe);

            return true;
        }
        public List<ISubscribe>? GetSubscribesBySubscribeId(int id)
        {
            var subs = _store.UsersSubscribes.FindAll(s => s.Owner.Id == id);

            return subs;
        }

        public ISubscribe? GetSubscribeByOwnerId(int id)
        {
            return _store.UsersSubscribes.FirstOrDefault(s => s.Owner.Id == id);
        }
        public ISubscribe? GetSubscribeById(int id)
        {
            return _store.UsersSubscribes.FirstOrDefault(s=>s.Id==id);
        }

        public List<ISubscribe> GetAll()
        {
            return _store.Subscribes;
        }
    }
}
