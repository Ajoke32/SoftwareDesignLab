

namespace lab5.State;

internal abstract class State
{

    private TextToHtmlConverter _context;
    
    public TextToHtmlConverter Context => _context;
    
    
    public void SetContext(TextToHtmlConverter context)
    {
        _context = context;
    }
    public abstract void Handle();


}