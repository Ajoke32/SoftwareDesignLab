using System;
using lab5.Composite.Interfaces;

namespace lab5.Command
{
	internal class DeleteCommand : Command
	{
		private readonly Editor _editor;
		private readonly Stack<int> _removedIndexes = new Stack<int>();

		public DeleteCommand(Editor editor) : base(editor)
		{
			_editor=editor;
		}

		public override void Execute()
		{
			var nodes = _editor.Nodes;
			var cursor = _editor.MoveCommand.NodeCursor;
			_removedIndexes.Push(cursor);
			var node = nodes[cursor];
			this.AddToHistory(node);
			nodes.Remove(node);
		}

		public override void Undo()
		{
			_editor.Nodes.Insert(_removedIndexes.Pop(),this.GetLastHistoryNode());
		}
	}
}
