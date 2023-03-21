using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Classes
{
    internal class SubscribeValidator
    {
        public bool SubscribeValidation(ISubscribe subscribe)
        {
            if (subscribe.GetType() == typeof(StudentSubscription))
            {

            }
            return true;
        }
        public bool ValidateStudentEmail(string email)
        {
            if (email.Contains("student") || email.Contains("edu"))
            {
                return true;
            }
            return false;
        }
    }
}
