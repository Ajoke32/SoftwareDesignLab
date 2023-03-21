using PaternsImpl.FactoryMethod.Apps;
using PaternsImpl.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.FactoryMethod.Classes
{
    internal class AppFactory
    {
        public IApplication CreateApp(string name,ISubscribeManager manager)
        {
            switch (name)
            {
                case "MobileApp": return new MobileApp(manager);
                case "WebSiteApp":return new WebSite(manager);
                case "ManagerCall":return new ManagerCall(manager);
                default: throw new Exception("App does not exist");
            }
        }
    }
}
