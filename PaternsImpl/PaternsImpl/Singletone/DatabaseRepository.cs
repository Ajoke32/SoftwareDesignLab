using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.Singletone
{
    sealed class DatabaseRepository
    {
        protected string ConnetionString = "mybasd.casd";
        private static DatabaseRepository _instance;
        private static object lockRef = new object();
        private DatabaseRepository()
        {
            Console.WriteLine("Db init...");
        }

        public static DatabaseRepository GetInstance()
        {
            lock (lockRef)
            {
                if (_instance == null)
                {

                    _instance = new DatabaseRepository();

                }
            }
            return _instance;
        }

    }
}
