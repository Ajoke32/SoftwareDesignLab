using lab5.State.Enums;

namespace lab5.State;

public static class ConsoleColorChanger
{
    public static void ChangeColor(string text,ErrorLevels level)
    {
        SetColor(level);
        Console.WriteLine(text);
        ResetColor();
    }

    private static void SetColor(ErrorLevels level)
    {
        switch (level)
        {
            case ErrorLevels.Low:
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
                break;
            case ErrorLevels.Medium:
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
                break;
            case ErrorLevels.Critical:
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
                break;
            default: throw new Exception("Color not exist");
        }
    }

    private static void ResetColor()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
}