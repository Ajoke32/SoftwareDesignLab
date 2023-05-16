namespace lab5.State.ConcreteStates;

internal class UploadState : State
{

    private IDocumentParser _parser;

    public UploadState(IDocumentParser parser)
    {
        _parser = parser;
    }
    public override void Handle()
    {
        try
        {
            Console.WriteLine("Parsing you text...");
            var parseResult = _parser.Render();
            Console.WriteLine("Upload to new file...");
            File.WriteAllText(Context.SavePath, parseResult);
            Console.WriteLine($"File uploaded, format: html\nPath: {Context.SavePath}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Process finished with error: {e.Message}");
        }
    }

    public void SetDocumentParser(IDocumentParser parser)
    {
        _parser = parser;
    }
}