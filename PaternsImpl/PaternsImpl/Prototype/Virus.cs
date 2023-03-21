using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaternsImpl.Prototype
{

    internal class Virus : ICloneable
    {
        public List<Virus> viruses = new List<Virus>();

        public Virus(int weight, int age, string? name, string? view)
        {
            Weight = weight;
            Age = age;
            Name = name;
            View = view;
        }
        public Virus(Virus prototype)
        {
            Weight =prototype.Weight;
            Age = prototype.Age;
            Name = prototype.Name;
            View = prototype.View;
        }

        public void AddVirus(Virus virus)
        {
            viruses.Add(virus);
        }

        public object Clone()
        {
            return new Virus(this);
        }

        public  int Weight { get; set; }

        public int Age { get; set; }
        
        public  string? Name { get; set; }

        public string? View { get; set; }

    }


}
