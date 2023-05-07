using System;
using System.Collections;
using lab5.Composite.Interfaces;

namespace lab5.Iterator.Strategy
{
	internal class IteratorStrategy : IEnumerable
	{
		private IEnumerator _enumerator;

		public IEnumerator GetEnumerator()
		{
			return _enumerator;
		}
		
		public void SetEnumerator(IEnumerator enumerator)
		{
			_enumerator = enumerator;
		}
		
	}
}
