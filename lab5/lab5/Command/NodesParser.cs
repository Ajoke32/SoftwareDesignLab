using System;
using System.Text;
using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;
using lab5.Iterator;
using lab5.Iterator.Strategy;

namespace lab5.Command
{
	internal static class NodesParser
	{

		public static IEnumerable<string> NodesToStringArray(List<ILightNode> nodes)
		{
			var text = new StringBuilder();
			
			foreach (var node in nodes)
			{
				if (node.Parent == null)
				{
					text.Append($"{node.Display()}\n");
				}
			}
			
			return text.ToString().TrimEnd().Split("\n");
		}

		public static IEnumerable<ILightNode> CreateNodeSequence(this List<ILightNode> nodes)
		{
			var iterator = new IteratorStrategy();
			iterator.SetEnumerator(new BreadthFirstIterator(nodes.ToArray()));
			return iterator.Cast<ILightNode>().ToList();
		}
		
	}
}
