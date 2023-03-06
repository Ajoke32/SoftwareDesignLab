using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Interfaces;

namespace WareHouseApp.Classes
{
    internal class HTMLReport : IReport
    {
        // наприклад потрібно реалізувати відображення репорту у HTML форматі
        // для цього нам не потрібно змінювати вже існуючий клас Report, створюючи там метод PrintHTML
        // або змінювати інтерфейс схожим чином. Достатньо тільки імплеметувати інтерфейс та реалізувати
        // метод PrintReport з тими специфічними змінами, які потребуються
        public Guid Id { get; set; }
        public Product? ProductInfo { get; set; }
        public string Description { get; set; } = String.Empty;
        public bool IsDeleted { get; set; }

        public void PrintReport()
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append($"<h1>Report {Id}<h1>\n" +
                $"<p>Product {ProductInfo.Name} {ProductInfo.Id}</p>\n" +
                $"<p>Arrival date: {ProductInfo.Arrivas}</p>\n" +
                $"<p>Description: {Description}</p>\n");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
