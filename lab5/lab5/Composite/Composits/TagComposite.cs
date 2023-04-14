using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Composits
{
	internal class TagComposite
	{
		protected List<ILightNode> nodes;

		public TagComposite()
		{
			nodes = new List<ILightNode>();
		}

		public void Display()
		{
			foreach (ILightNode node in nodes)
			{

				Console.WriteLine(node.Display());

			}
		}

		public void AddChild(ILightNode node)
		{
			nodes.Add(node);
		}
		public void RemoveNode(ILightNode node)
		{
			nodes.Remove(node);
		}

		public object Copy()
		{
			return nodes;
		}

	}
}
