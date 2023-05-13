using lab5.Composite.Interfaces;

namespace lab5.Command
{
	internal class CopyCommand : Command
	{
		private readonly Editor _editor;
		public ILightNode? Buff { get; private set; }

		public CopyCommand(Editor editor) : base(editor)
		{
			_editor = editor;
		}

		public override void Execute()
		{
			Buff = _editor.GetSelectedNode();
		}
		
		public override void Undo()
		{
			Buff = null;
		}
	}
}
