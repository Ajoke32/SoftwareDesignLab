using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;

namespace WareHouseApp.Interfaces
{
    internal interface IReportingService //interface segregation principle інтерфейси поділені на більш малі частини,  що відповідають за певний функціонал
    {
        //наприклад цей інтерфейс відповідає за роботу з звітністю на складі
        public void CreateReport(IReport report);

        // open–closed principle, ми можемо
        // розширяти класи, створювати більше спецефічні класи за допомогою IReportingService
        // при цьому не змінюючи код самого інтерфейсу та його вже існуючих наслідуваних об'єктів
    }
}
