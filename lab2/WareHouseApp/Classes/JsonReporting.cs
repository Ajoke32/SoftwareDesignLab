using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WareHouseApp.Interfaces;
using WareHouseApp.Stores;

namespace WareHouseApp.Classes
{
    // зберігання данних в json форматі
    internal class JsonReporting : IReportingService
    {
       
        private string _path = Directory.GetCurrentDirectory()+"/Report.json";

        private Store _store;

        public int ProductCount { get; set; }


        public JsonReporting(Store store)
        {
            _store = store;
        }
   
        public void CreateReport(IReport report)
        {
            if (File.Exists(_path))
            {
                _store.reports.Add(report);
                SaveData();
            }
        }
        private void SaveData()
        {
            if (File.Exists(_path))
            {
                string jsonString = JsonSerializer.Serialize(_store.reports);
                File.WriteAllText(_path, jsonString);
            }

        }

    }
}
