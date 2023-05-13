using lab5.Composite.Interfaces;

namespace lab5.Command
{
	internal class Editor
	{
		public List<string> Lines {get;private set;}

		public MoveCommand MoveCommand {get;} 
		public CopyCommand CopyCommand { get;}
		public List<ILightNode> Nodes{get;}

		private readonly CommandHistory _history;
		public TextCommand TextCommand { get;}
		public Editor(List<ILightNode> nodes)
		{
			Lines = NodesParser.NodesToStringArray(nodes).ToList();
			Nodes = nodes;
			_history = new CommandHistory();
			MoveCommand = new MoveCommand(this);
			CopyCommand = new CopyCommand(this);
			TextCommand = new TextCommand(this);
		}

		public void Start()
		{
			
			var deleteCommand = new DeleteCommand(this);
			var insertBeforeCommand = new InsertBeforeCommand(this);
			TextCommand.Execute();
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch(key)
				{
					case ConsoleKey.DownArrow:MoveCommand.Execute();
						break;
					case ConsoleKey.UpArrow:MoveCommand.Undo();
						break;
					case ConsoleKey.C:
					{
						ExecuteCommand(CopyCommand);
						ShowPrompt("node copied!");
					}
						break;
					case ConsoleKey.D:
					{
						ExecuteCommand(deleteCommand);
						Render();
						MoveCommand.ResetCursor();
					}
						break;
					case ConsoleKey.I:
					{
						ExecuteCommand(insertBeforeCommand);
						Render();
					} 
						break;
					case ConsoleKey.U:
					{
						Undo();
						Render();
					} 
						break;
				}

			} while (key != ConsoleKey.E);
		}
		
		public ILightNode GetSelectedNode()
		{
			return MoveCommand.GetSelectedNode();
		}

		private void Render()
		{
			Lines=NodesParser.NodesToStringArray(Nodes).ToList();
			TextCommand.Execute();
			MoveCommand.ResetCursor();
		}

		private void ShowPrompt(string msg="")
		{
			TextCommand.ShowPrompt(msg);
			MoveCommand.SetCursorToRowValue();
		}

		private void ExecuteCommand(Command command)
		{
			command.Execute();
			_history.AddCommand(command);
		}

		private void Undo()
		{
			if (_history.IsEmpty())
			{
				return;
			}
			var command = _history.GetLastCommand();
			command.Undo();
		}
		

	}
}
