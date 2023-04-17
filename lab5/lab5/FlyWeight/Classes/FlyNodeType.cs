using System;
using lab5.Composite.Clasess;

namespace lab5.FlyWeight.Classes
{
	internal class FlyNodeType
	{
		public ViewType ViewType { get; }
		public string Name { get; protected set; }
		public ClosureType ClosureType { get; protected set; }
		
		public FlyNodeType(string name)
		{
			Name = name;
		}
	}
}
