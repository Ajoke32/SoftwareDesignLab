using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Interfaces
{
    internal interface INodeEditor
    {
        public void AppendChild(ILightNode node);

        public void RemoveChild(ILightNode node);

        public void ReplaceChild(ILightNode node, ILightNode replaceNode);

        public void InsertBefore(ILightNode node,ILightNode refNode);

    }
}
