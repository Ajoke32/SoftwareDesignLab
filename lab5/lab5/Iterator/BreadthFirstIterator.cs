using System;
using System.Collections;
using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;

namespace lab5.Iterator
{
	internal class BreadthFirstIterator : IEnumerator
	{
		private readonly Queue<LightElementNode> _queue = new Queue<LightElementNode>();
		private readonly LightElementNode _node = new LightElementNode("root",ClosureType.Patrial,ViewType.Block);

		private LightElementNode _current;

		public BreadthFirstIterator(LightElementNode rootNode)
		{
			_node.AppendChild(rootNode);
			_current=_node;
		}
		public BreadthFirstIterator(ILightNode[] nodes)
		{
			foreach(var node in nodes)
			{
				_node.AppendChild(node);
			}
			_current =_node;
		}
		public object Current => _current;

		
		public bool MoveNext()
		{

			if (_current.HasChilds())
			{
				_queue.Enqueue((LightElementNode)_current.Nodes[0]);
			}
			if (_current.NextElementSibling != null)
			{
				_current = _current.NextElementSibling;
				return true;
			}
			
			if (_queue.Count == 0)
			{
				foreach (var node in _node.Nodes)
				{
					node.RemoveParent();
				}
				return false;
			}
			if (_current.NextElementSibling == null)
			{
				_current = _queue.Dequeue();
			}
			return true;
		}

		public void Reset()
		{
			_current = _node;
		}
	}
}
