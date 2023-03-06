using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseApp.Classes
{
    internal class Dollar : Money
    {
        // Приклад, коли деталі залежать від астракції, а не на навпаки
        public override char Sign { get=>'$'; }
        public override string ShortName { get => "USD" ;}
    }
}
