using System;
using System.Collections;
using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;

namespace lab5.Iterator
{
	internal class DepthFirstIterator : IEnumerator
	{

		private Stack<LightElementNode> _stack;
		
		private LightElementNode _current;

		private readonly LightElementNode _root = new LightElementNode("div", ClosureType.Patrial, ViewType.Block);

		public DepthFirstIterator(LightElementNode root)
		{
			_root.AppendChild(root);
			InitMembers();
		}
		public DepthFirstIterator(LightElementNode[] nodes)
		{
			foreach (var item in nodes)
			{
				_root.AppendChild(item);
			}
			InitMembers();
		}
		object IEnumerator.Current => Current;

		private void InitMembers()
		{
			_current = _root;
			_stack = new Stack<LightElementNode>();
		}
		public bool MoveNext()
		{
			if (_current.NextElementSibling != null)
			{
				if (!_stack.Contains(_current.NextElementSibling))
				{
					_stack.Push(_current.NextElementSibling);
				}
			}
			if (_current.HasChilds())
			{
				for (int i = _current.Nodes.Count - 1; i >= 0; i--)
				{
					_stack.Push((LightElementNode)_current.Nodes[i]);
				}
			}

			if (_stack.Count > 0)
			{
				_current = _stack.Pop();
				return true;
			}

			return false;
		}


		public void Reset()
		{
			_current = _root;
		}


		public ILightNode Current
		{
			get
			{
				try
				{
					return _current;
				}
				catch (Exception)
				{
					throw new InvalidOperationException();
				}
			}
		}
	}

}
