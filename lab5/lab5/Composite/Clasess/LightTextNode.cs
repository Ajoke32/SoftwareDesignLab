using lab5.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Clasess
{
    internal class LightTextNode : ILightNode
    {
        protected string? Text;

 
        public LightTextNode(string? text)
        {
            Text = text;
        }
        

        public ViewType ViewType { get; }

        public string? Display()
        {
            return Text;
        }
    }
}
