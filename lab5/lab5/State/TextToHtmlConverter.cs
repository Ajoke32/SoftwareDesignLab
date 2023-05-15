using lab5.State.ConcreteStates;
using lab5.State.Enums;

namespace lab5.State;

internal class TextToHtmlConverter
{
    private State _state;
    
    public string ConvertFrom { get; set; }
    public string SavePath { get; set; }

    private Dictionary<ErrorLevels, List<CustomError>>? _errors;
    public Dictionary<ErrorLevels, List<CustomError>>? Errors
    {
        get=>_errors;
        set => _errors ??= value;
    }

    public TextToHtmlConverter()
    {
        _state = new InitialState();
        _state.SetContext(this);
    }
    
    public void Handle(State state)
    {
        _state = state;
        _state.Handle();
    }
    
 
    
}