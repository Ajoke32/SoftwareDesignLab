using System;
using lab5.Composite.Interfaces;

namespace lab5.Composite.Clasess
{
	internal abstract class BaseNode : ILightNode
	{
		protected LightElementNode? _parent=null;
		public abstract ViewType ViewType { get; }

		public LightElementNode? Parent
		{
			get=>_parent;
			set
			{
				if(value!=null&&value.HaveChild(this))
				{
					_parent=value;
				}
			}
		}

		public abstract string Display();
	}
}
