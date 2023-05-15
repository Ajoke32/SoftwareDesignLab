using lab5.State.Enums;

namespace lab5.State;

public class CustomError
{
    public int Code { get; set; }
    
    public string Message { get; set; }
    
    public ErrorLevels ErrorLevel { get; set; }
}