using System;
using lab5.Composite.Interfaces;

namespace lab5.Command
{
	internal abstract class Command
	{
		private Editor _editor;
		public Command(Editor editor)
		{
			_editor = editor;
		}
		public abstract void Execute();
		
		public virtual void Undo()
		{
			
		}
	}
}
