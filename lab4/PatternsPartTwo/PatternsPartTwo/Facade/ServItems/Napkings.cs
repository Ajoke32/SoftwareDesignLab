using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Facade.ServItems
{
    internal class Napkings
    {
        public int Count { get; set; } = 4;
        
        public int GetDefaultCout()
        {
            return Count;
        }
        public int GetDoubleCout()
        {
            return Count*2;
        }
        public int ComputeForPeople(int people)
        {
            return 2*people;
        }
        public int GetForBigPortion()
        {
            return 20;
        }

    }
}
