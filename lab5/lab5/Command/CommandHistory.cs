namespace lab5.Command;

internal class CommandHistory
{
    private readonly Stack<Command> _history;
    
    public CommandHistory()
    {
        _history = new Stack<Command>();
    }

    public void AddCommand(Command command)
    {
        _history.Push(command);
    }

    public bool IsEmpty()
    {
        return !_history.Any();
    }
    public Command GetLastCommand()
    {
        return _history.Pop();
    }
}