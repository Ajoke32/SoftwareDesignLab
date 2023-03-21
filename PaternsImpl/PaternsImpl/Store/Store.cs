using PaternsImpl.FactoryMethod.Classes;
using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl
{
    internal class Store
    {

        public List<User> Users { get; set; } = new List<User>();

        public List<ISubscribe> UsersSubscribes { get; set; } = new List<ISubscribe>();
        public List<ISubscribe> Subscribes { get; set; } = new List<ISubscribe>();

    }
}
