using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;

namespace WareHouseApp.Stores
{
    internal class Store
    {
        public List<Reporting> Reports { get; } = new List<Reporting>();

        public List<Category> Categories { get; } = new List<Category>();
    }
}
