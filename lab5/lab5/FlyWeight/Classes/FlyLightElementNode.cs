using System;
using System.Text;
using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;
using lab5.FlyWeight.Classes.Factories;

namespace lab5.FlyWeight.Classes
{
	internal class FlyLightElementNode : INodeEditor
	{
		public Dictionary<string, string> Attributes { get; protected set; }

		public List<ILightNode> Nodes { get; protected set; }
		
		public FlyNodeType NodeType { get; protected set; }
		
		private StringBuilder _strBuilder;
		public FlyLightElementNode(string name)
		{
			NodeType = FlyNodeTypeFactory.CreateElement(name);
			_strBuilder = new StringBuilder();
			Nodes = new List<ILightNode>();
		}
		
		public void SetChilds()
		{
			foreach (var node in Nodes)
			{
				_strBuilder.Append(node.Display());
			}
		}
		
		public void AppendChild(ILightNode node)
		{
			Nodes.Add(node);
		}
		public string Display()
		{
			_strBuilder.Append($"<{NodeType.Name}>");
			 SetChilds();
			_strBuilder.Append($"<{NodeType.Name}/>\n");
			
			return _strBuilder.ToString();
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

        public void InsertBefore(ILightNode node, ILightNode refNode)
        {
            int index = Nodes.IndexOf(refNode);
			if (index != -1)
			{
				Nodes.Insert(index + 1, node);
			}
        }
    }
}
