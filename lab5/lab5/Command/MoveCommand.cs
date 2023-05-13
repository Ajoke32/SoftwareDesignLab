using System;
using System.Windows.Input;
using lab5.Composite.Interfaces;

namespace lab5.Command
{
	internal class MoveCommand : Command
	{
		private const int MenuDepth = 1;

		public int NodeCursor { get; private set; } = 0;
		
		public int RowCursor { get; private set; }

		private readonly Editor _editor;
		public MoveCommand(Editor editor) : base(editor)
		{
			_editor = editor;
			RowCursor = MenuDepth;
		}

		public override void Execute()
		{
			
			RowCursor++;
			CheckCursor();
			if (RowCursor > _editor.Lines.Count + MenuDepth) return;
			Console.SetCursorPosition(0, RowCursor);
			NodeCursor++;
			HightLighter.HightLight(_editor.Lines[NodeCursor]);
			Console.SetCursorPosition(0, RowCursor - 1);
			HightLighter.UndoHightLight(_editor.Lines[NodeCursor - 1]);
			Console.SetCursorPosition(0, RowCursor);
		}
		
		public override void Undo()
		{
			RowCursor--;
			CheckCursor();
			if (RowCursor <= _editor.Lines.Count+MenuDepth)
			{
				Console.SetCursorPosition(0, RowCursor);
				NodeCursor--;
				HightLighter.HightLight(_editor.Lines[NodeCursor]);

				Console.SetCursorPosition(0, RowCursor + 1);
				HightLighter.UndoHightLight(_editor.Lines[NodeCursor + 1]);
			}
			Console.SetCursorPosition(0, RowCursor);
		}

		private void CheckCursor()
		{
			if (RowCursor < MenuDepth)
			{
				RowCursor = MenuDepth;
				NodeCursor=1;
			}
			else if (RowCursor >= _editor.Lines.Count)
			{
				RowCursor = _editor.Lines.Count;
				NodeCursor=_editor.Lines.Count-2;
			}
		}
		
		public ILightNode GetSelectedNode()
		{
			return _editor.Nodes[NodeCursor];
		}
		
		public void SetCursorToRowValue()
		{
			Console.SetCursorPosition(0,RowCursor);
		}
		
		public void ResetCursor()
		{
			RowCursor = MenuDepth;
			NodeCursor=0;
		}

	}
}
