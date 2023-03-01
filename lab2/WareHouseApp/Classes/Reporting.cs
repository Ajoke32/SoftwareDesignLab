using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Interfaces;

namespace WareHouseApp.Classes
{
    internal class Reporting : IReportingService
    {
        private List<Report> _reports;

        public int ProductCount { get; set; }


        public Reporting()
        {
            _reports = new List<Report>();
        }

        public void CreateReport(Product product, string description = "no additional information available", bool isDeleted =false)
        {
            _reports.Add(new Report
            {
                Id = Guid.NewGuid(),
                ProductInfo= product,
                Description= description,
                IsDeleted= isDeleted
            });
        }

        public void GetProfitableInvoice()
        {
            Console.WriteLine("\n-----------Profitable Invoice----------\n");
            var profInvoce = _reports.FindAll(r => r.IsDeleted == false);
            foreach(var prof in profInvoce)
            {
                prof.PrintReport();
            }
        }

        public void GetExpenseInvoice()
        {
            Console.WriteLine("\n-----------Expense Invoice----------\n");
            var profInvoce = _reports.FindAll(r => r.IsDeleted == true);
            foreach (var prof in profInvoce)
            {
                prof.PrintReport();
            }
        }

        public void GetReports()
        {
            foreach (Report report in _reports)
            {
                report.PrintReport();
            }
        }

    


    }
}
