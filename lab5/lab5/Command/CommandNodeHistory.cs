using lab5.Composite.Interfaces;

namespace lab5.Command;

internal static class CommandNodeHistory
{
    private static readonly Dictionary<Command, Stack<ILightNode>> _history
        = new Dictionary<Command, Stack<ILightNode>>(){ };

    public static void AddToHistory(this Command command,ILightNode node)
    {
        if (!_history.ContainsKey(command))
        {
            _history.Add(command, new Stack<ILightNode>());
        }
        _history[command].Push(node);
    }

    public static ILightNode GetLastHistoryNode(this Command command)
    {
        return _history[command].Pop();
    }
}