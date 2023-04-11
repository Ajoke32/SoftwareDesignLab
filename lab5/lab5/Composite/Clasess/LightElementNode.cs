using lab5.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Clasess
{

    public enum ViewType
    {
        Block,
        String
    }

    enum ClosureType
    {
        Single,
        Patrial
    }
    internal class LightElementNode : ILightNode, INodeEditor, ICloneable
    {
        public Dictionary<string, string> Attributes { get; protected set; }

        public ViewType ViewType { get; protected set; }

        public string? Name { get; protected set; }

        public ClosureType ClosureType { get; protected set; }

        public List<ILightNode> Nodes { get; protected set; }

        public void SetAttributes(Dictionary<string, string> attributes)
        {
            Attributes = attributes;
        }
        public LightElementNode(string name, ClosureType closure, ViewType view)
        {
            Name = name;
            ClosureType = closure;
            ViewType = view;
            Nodes = new List<ILightNode>();
            Attributes = new Dictionary<string, string>();
        }

        public LightElementNode()
        {
            Nodes = new List<ILightNode>();
            Attributes = new Dictionary<string, string>();
        }

        public LightElementNode(LightElementNode prototype)
        {
            ClosureType = prototype.ClosureType;
            Nodes = prototype.Nodes;
            Attributes = prototype.Attributes;
            ViewType = prototype.ViewType;
            Name = prototype.Name;
        }

        public void AppendChild(ILightNode node)
        {

            if (!TagValidator.IsAppendable(this))
            {
                throw new Exception($"The tag type is not support appending");
            }

            int index = Nodes.IndexOf(node);
            if (index == -1)
            {
                Nodes.Add(node);
            }
        }
       

        public string Display()
        {

            var tagBuilder = new LightELementBuilder();
            
            if(ClosureType==ClosureType.Single)
            {
                return tagBuilder.SetNode(this)
                .SetOpenBracket()
                .SetAttributes()
                .SetChilds()
                .SetCloseBracket()
                .TagToString();
            }

            return tagBuilder.SetNode(this)
                .SetOpenBrackets()
                .SetAttributes()
                .SetChilds()
                .SetCloseBrackets()
                .TagToString();       
        }

        public string InnerHtml()
        {
            var builder = new StringBuilder();
            foreach (var node in Nodes)
            {
                builder.Append(node.Display());
            }

            return builder.ToString();
        }

        public string? OuterHtml()
        {
            return Display();
        }

        public void RemoveChild(ILightNode node)
        {
            Nodes.Remove(node);
        }

        public void ReplaceChild(ILightNode node, ILightNode replaceNode)
        {
            int index = Nodes.IndexOf(node);

            if (index != -1)
            {
                Nodes[index] = replaceNode;
            }
        }

        public void InsertBefore(ILightNode refNode, ILightNode node)
        {
            int index = Nodes.IndexOf(refNode);
            if (index != -1)
            {
                Nodes.Insert(index + 1, node);
            }
        }

        public object Clone()
        {
            return new LightElementNode(this);
        }
    }
}
