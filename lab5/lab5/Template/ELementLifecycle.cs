using System;
using lab5.Composite.Clasess;

namespace lab5.Template
{
	internal abstract class ELementLifecycle : BaseNode
	{

		public void TemplateMethod()
		{
			if(!ValidateState())
			{
				System.Console.WriteLine("tag was be deleted or not exist");
				return;
			}
			if (State.IsCreated)
			{
				OnCreated();
			}
			if (IsStylesSupported())
			{
				OnStylesApplied();
			}
			if (this.Parent != null)
			{
				OnInserted();
			}
			if (State.IsRemoved)
			{
				OnDeleted();
			}
		}
		protected bool IsStylesSupported()
		{
			return this is LightElementNode;
		}
		
		protected bool ValidateState()
		{
			return this.State!=null;
		}
		public virtual void OnCreated()
		{
			System.Console.Write("Element created");
		}

		public virtual void OnDeleted()
		{
			System.Console.Write("Element deleted from DOM");
		}

		public virtual void OnStylesApplied()
		{
			System.Console.Write("Styles was be applied");
		}

		public virtual void OnInserted()
		{
			System.Console.WriteLine($"Element inserted to tag {this.Parent.Name}");
		}
			
		public virtual void Hook(){}
	}
}
