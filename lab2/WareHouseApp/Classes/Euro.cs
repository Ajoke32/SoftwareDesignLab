using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseApp.Classes
{
    internal class Euro : Money
    {
        public override char Sign { get=>'Є';}

        public override string ShortName => "EUR";
    }
}
