using lab5.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Clasess
{
    internal class LightTextNode : BaseNode
    {
        protected string Text;
        public override ViewType ViewType { get; }

        public int Ident { get; set; } = 0;

        public LightTextNode(string text)
        {
            Text = text;
            ViewType = ViewType.String;
        }

        public override string Display()
        {
            var s = new StringBuilder();
            if (Parent != null)
            {
                for (int i = 0; i < Parent.Ident; i++)
                {
                    s.Append("\t");
                }
            }
            return s.Append(Text).ToString();
        }
    }
}
