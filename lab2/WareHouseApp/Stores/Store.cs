using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;
using WareHouseApp.Interfaces;

namespace WareHouseApp.Stores
{
    internal class Store
    {
        public List<IReport> reports { get; set; } =  new List<IReport>();
        public List<Category>? Categories { get; set; }
    }
}
