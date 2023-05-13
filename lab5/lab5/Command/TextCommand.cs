using System;
using System.Text;

namespace lab5.Command
{
	internal class TextCommand : Command
	{
		private readonly Editor _editor;

		private readonly string _menu;
		public TextCommand(Editor editor) : base(editor)
		{
			_editor = editor;
			_menu = "Menu. c-copy, i-insert before, d-delete, u-undo command";
		}

		public override void Execute()
		{
			Console.Clear();
			Console.WriteLine(_menu);
			HightLighter.HightLight(_editor.Lines[0]);
			for (int i = 1; i < _editor.Lines.Count; i++)
			{
				Console.WriteLine(_editor.Lines[i]);
			}
			Console.SetCursorPosition(0, 1);
		}

		public void ShowPrompt(string msg = "")
		{
			Console.SetCursorPosition(0,0);
			Console.SetCursorPosition(_menu.Length+5, 0);
			Console.WriteLine(msg);
		}
	}
}
