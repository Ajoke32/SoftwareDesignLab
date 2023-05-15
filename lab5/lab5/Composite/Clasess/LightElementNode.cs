using lab5.Composite.Interfaces;
using lab5.Template;
using System.Text;


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
    internal class LightElementNode : ELementLifecycle, INodeEditor, ICloneable
    {
        private readonly string[] _availableAtributes = { "class", "style", "id" };
        private readonly string[] _availableStyles = { "color", "border", "display",
         "text-align", "justify-content", "align-items", "transform","background-color" };

        public Dictionary<string, string> Attributes { get; private set; }

        public override string Name { get; }

        public ClosureType ClosureType { get; }

        public List<ILightNode> Nodes { get; }

        public override ViewType ViewType { get; }
        public int Ident { get; set; } = 0;

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
            Parent = prototype.Parent;
        }

        public void AppendChild(ILightNode node)
        {
            if (!this.IsAppendable())
            {
                throw new Exception($"The tag type is not support appending");
            }

            int index = Nodes.IndexOf(node);
            if (index == -1)
            {
                Nodes.Add(node);
                node.Parent = this;
                
                if (node is LightElementNode)
                {
                    var inserted = (LightElementNode)node;
                    if (inserted.NextElementSibling != null)
                    {
                        inserted.NextElementSibling = null;
                    }
                    if (node.Parent != null)
                    {
                        int nodeIndex = node.Parent.Nodes.IndexOf(node);
                        if (nodeIndex > 0)
                        {
                            ((LightElementNode)node.Parent.Nodes[nodeIndex - 1]).NextElementSibling = (LightElementNode)node;
                        }
                    }
                }
                node.State.IsInserted = true;
            }
            else
            {
                throw new Exception("this element already in DOM!");
            }
        }


        public override string Display()
        {
            var tagBuilder = new LightELementBuilder();
            if (ClosureType == ClosureType.Single)
            {
                return tagBuilder.SetNode(this)
                .SetIdent()
                .SetOpenBracket()
                .SetAttributes()
                .SetSlash()
                .SetCloseBracket()
                .TagToString();
            }

            return tagBuilder.SetNode(this)
                .SetIdent()
                .SetOpenBracket()
                .SetAttributes()
                .SetCloseBracket()
                .SetChilds()
                .SetIdent()
                .SetCloseBrackets()
                .TagToString();;
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


        protected override void OnStylesApplied()
        {
            bool error = false;
            if (Attributes.ContainsKey("style"))
            {
                string style = Attributes["style"].Replace(" ", "");
                string[] styles = style.Split(";");

                foreach (var item in styles)
                {
                    if (String.IsNullOrEmpty(item))
                    {
                        continue;
                    }
                    if (Array.IndexOf(_availableStyles, item.Substring(0, item.IndexOf(":"))) == -1)
                    {
                        error = true;
                    }
                }
            }
            base.OnStylesApplied();
            if (error)
            {
                Console.Write(" with error, check available styles {____}\n");
                return;
            }
            Console.Write(" without error\n");
        }

        protected override void OnDeleted()
        {
            CleanListeners();
            base.OnDeleted();
            Console.Write(" memory is freed up\n");
        }

        protected override void OnCreated()
        {
            base.OnCreated();
            foreach (var attr in Attributes.Keys)
            {
                if (Array.IndexOf(_availableAtributes, attr) == -1)
                {
                    Console.WriteLine(" with error, check available attributes and naming conventions {____}");
                    return;
                }
            }
            Console.WriteLine(" successfully");
        }

        public string? OuterHtml()
        {
            return Display();
        }

        public void RemoveChild(ILightNode node)
        {
            Nodes.Remove(node);
            node.State.IsRemoved = true;
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
