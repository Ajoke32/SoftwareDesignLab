using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseApp.Classes
{
    internal class Product
    {

        public int Id { get; set; }
        public string? Name { get; set; } 
        public Category? Category { get; set; }

        public Money? Price { get; set; }

        public string? Unit { get; set; }

        public DateTime? Arrivas { get; set; }


    }
}
