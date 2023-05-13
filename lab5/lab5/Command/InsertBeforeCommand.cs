using lab5.Composite.Factory;
using lab5.Composite.Interfaces;


namespace lab5.Command;

internal class InsertBeforeCommand:Command
{
    private readonly Editor _editor;
    
    public InsertBeforeCommand(Editor editor) : base(editor)
    {
        _editor = editor;
    }

    public override void Execute()
    {
        var cursor = _editor.MoveCommand.NodeCursor;
        var nodes = _editor.Nodes;
        var buff = _editor.CopyCommand.Buff;
        var tagFactory = new TagFactory();
        if (buff != null)
        {
            var node = tagFactory.CreateElement(buff.Name);
            this.AddToHistory(node);
            nodes.Insert(cursor + 1, node);
        }
        else
        {
            Console.SetCursorPosition(0,nodes.Count+1);
            Console.WriteLine("Choose tag: 1.div 2.p");
            var res = Console.ReadLine();
            if (string.IsNullOrEmpty(res))
            {
                return;
            }

            var node = tagFactory.CreateElement(res == "1" ? "div" : "p");
            this.AddToHistory(node);
            nodes.Insert(cursor+1,node);
        }
    }

    public override void Undo()
    {
        _editor.Nodes.Remove(this.GetLastHistoryNode());
    }
}