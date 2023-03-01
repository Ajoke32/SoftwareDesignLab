using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseApp.Classes
{
    internal class Dollar : Money
    {
        public override char Sign { get=>'$'; }
        public override string ShortNmae { get => "USD" ;}
    }
}
