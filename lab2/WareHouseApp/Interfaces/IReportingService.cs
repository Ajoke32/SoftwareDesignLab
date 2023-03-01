using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;

namespace WareHouseApp.Interfaces
{
    internal interface IReportingService
    {
        public void CreateReport(Product product,string description = "no additional information available", bool isDeleted = false);
    }
}
