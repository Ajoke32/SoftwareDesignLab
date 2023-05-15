namespace lab5.State.ConcreteStates;

internal class UploadState : State
{

    private IDocumentParser _parser;

    public UploadState()
    {
        _parser = new DocumentParser(Context.ConvertFrom);
    }
    public override void Handle()
    {
        Console.WriteLine("Parsing you text...");
        var parseResult = _parser.Render();
        Console.WriteLine("Upload to new file...");
        File.WriteAllText(Context.SavePath,parseResult);
        Console.WriteLine("File uploaded, format: html");
    }

    public void SetDocumentParser(IDocumentParser parser)
    {
        _parser = parser;
    }
}