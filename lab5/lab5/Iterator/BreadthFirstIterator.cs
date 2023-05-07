using System;
using System.Collections;
using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;

namespace lab5.Iterator
{
	internal class BreadthFirstIterator : IEnumerator
	{
		private Queue<LightElementNode> _queue = new Queue<LightElementNode>();
		private LightElementNode _node = new LightElementNode("div",ClosureType.Patrial,ViewType.Block);

		private LightElementNode _current;

		public BreadthFirstIterator(LightElementNode rootNode)
		{
			_node.AppendChild(rootNode);
			_current=_node;
		}
		public BreadthFirstIterator(LightElementNode[] nodes)
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
			//умова виходу
			if (_queue.Count == 0)
			{
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
