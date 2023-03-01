using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Interfaces;
using WareHouseApp.Managers;
using WareHouseApp.Stores;

namespace WareHouseApp.Classes
{
    internal class WareHouse
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime LastUpdate { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public IWareHouseManager? Manager { get; set; }

    }
}
