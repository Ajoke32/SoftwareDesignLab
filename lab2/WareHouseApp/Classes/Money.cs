using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WareHouseApp.Interfaces;

namespace WareHouseApp.Classes
{

    internal abstract class Money
    {
        // dependency inversion principle
        // Абстракція не повинна бути залежною від деталей, деталі повинні бути залежні від абстракції
        // це модуль верхнього рівня і він не залежить від модулів нижнього рівня
      
        protected int Entire;
        protected int Coin;
        public bool SetMoney(int entire, int coin)
        {
            if(entire>=0&&coin>=0&&coin<=99)
            {
                Entire = entire;
                Coin = coin;
                Console.WriteLine("Successfully");
                return true;
            }
            Console.WriteLine("Fail, check you input!");
            return false;
        }
        public abstract char Sign { get; }
        public abstract string ShortName { get; }
        public string PrintMoney()
        {
            return $"{Entire}.{Coin} {Sign}";
        }
    }
}
