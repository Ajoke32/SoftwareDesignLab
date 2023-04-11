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
    internal class LightElementNode : ILightNode, INodeEditor
    {
        public Dictionary<string, string> Attributes { get; set; }

        public ViewType ViewType { get; }

        public string? Name { get; }

        public ClosureType ClosureType { get; }

        public List<ILightNode> Nodes { get; set; }


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
        private string GetAngleBracket(bool closed = false)
        {

            StringBuilder strBuider = new StringBuilder();
            strBuider.Append(!closed ? "<" : "</");
            strBuider.Append(Name);
            if (Attributes.Count > 0 && !closed)
            {
                strBuider.Append(GetAttributes());
            }
            strBuider.Append(">");
            return strBuider.ToString();
        }

        private string GetAttributes()
        {
            StringBuilder strBuider = new StringBuilder();
            foreach (var item in Attributes)
            {
                strBuider.Append($" {item.Key}='{item.Value}'");
            }
            return strBuider.ToString();
        }
        private string GetSingleBrackets(bool closed = false)
        {

            StringBuilder strBuider = new StringBuilder();
            strBuider.Append("<");
            strBuider.Append(Name);
            if (Attributes.Count > 0)
            {
                strBuider.Append(GetAttributes());
            }
            strBuider.Append("/>");
            return strBuider.ToString();
        }

        public string? Display()
        {
            var tagBuilder = new LigthELementBuilder();

            return tagBuilder.SetNode(this)
                .SetOpenBracket()
                .SetAttributres()
                .SetChilds()
                .SetCloseBracket().TagToString();
            /*
            StringBuilder stringBuilder = new StringBuilder();
            if (ClosureType == ClosureType.Single)
            {
                stringBuilder.Append(GetSingleBrackets());
                return stringBuilder.ToString();
            }
            stringBuilder.Append(GetAngleBracket());
            if (Nodes.Count > 0)
            {
                foreach (var node in Nodes)
                {
                    stringBuilder.Append("\n"+node.Display()+"\n");
                }
            }
            stringBuilder.Append(GetAngleBracket(true));
            return stringBuilder.ToString();*/
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
            Nodes.Insert(index + 1, node);
        }
    }
}
