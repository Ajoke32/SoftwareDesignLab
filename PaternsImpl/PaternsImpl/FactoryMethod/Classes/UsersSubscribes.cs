using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Classes
{
    internal class UsersSubscribes
    {
        public int Id { get; set; }
        public User? User { get; set; } 
        public ISubscribe? Subscribe { get; set; }
    }
}
