using lab5.Composite.Clasess;


namespace lab5.Template
{
	internal abstract class ELementLifecycle : BaseNode
	{

		public void TemplateMethod()
		{
			if(!ValidateState())
			{
				Console.WriteLine("tag was be deleted or not exist");
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
			if (Parent != null)
			{
				OnInserted();
			}
			if (State.IsRemoved)
			{
				OnDeleted();
			}
		}
		
		private bool IsStylesSupported()
		{
			return this is LightElementNode;
		}

		private bool ValidateState()
		{
			return State!=null;
		}

		protected virtual void OnCreated()
		{
			Console.Write("Element created");
		}

		protected virtual void OnDeleted()
		{
			Console.Write("Element deleted from DOM");
		}

		protected virtual void OnStylesApplied()
		{
			Console.Write("Styles was be applied");
		}

		protected virtual void OnInserted()
		{
			Console.WriteLine($"Element inserted to tag {Parent?.Name}");
		}
			
		public virtual void Hook(){}
	}
}
