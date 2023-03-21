using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaternsImpl.Prototype
{

    internal class VirusChild : Virus, ICloneable
    {
        public VirusChild(int weight, int age, string? name, string? view, DateTime? birthDate, Virus parent) : base(weight, age, name, view)
        {
            Weight = weight;
            Age = age;
            Name = name;
            View = view;
            BirthDate = birthDate;
            Parent = parent;    
        }
        public VirusChild(VirusChild prototype):base(prototype)
        {
            Weight= prototype.Weight;
            Age= prototype.Age;
            Name= prototype.Name;
            View = prototype.View;
            BirthDate= prototype.BirthDate;
            Parent = prototype.Parent;
        }
        public Virus Parent { get; set; }
        public DateTime? BirthDate { get; set; }

        public object Clone()
        {
            return new VirusChild(this);
        }
    }
}
