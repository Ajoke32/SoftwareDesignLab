using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseApp.Classes
{
    internal class Report
    {
        public Guid Id { get; set; }
        public Product? ProductInfo { get; set; }
        public string Description { get; set;} = String.Empty;

        public bool IsDeleted { get; set; }

        public void PrintReport()
        {
            Console.WriteLine($"| Report {Id} |\nProduct {ProductInfo.Name} {ProductInfo.Id}(id)" +
                   $"\nArrival date:{ProductInfo.Arrivas}\n{Description}" +
                   $"\n-------------------------------------\n");
        }
    }
}
