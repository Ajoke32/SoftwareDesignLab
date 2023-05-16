using System.Runtime.InteropServices.JavaScript;
using lab5.State.Enums;

namespace lab5.State.ConcreteStates;

internal class InitialState:State
{
    
    public override void Handle()
    {
        if (Context.Errors != null)
        {
            Console.WriteLine("Ready to upload document");
            return;
        }
        
        Console.WriteLine("Initialization of the load...");
        Context.Errors = InitErrors();
        Console.WriteLine("Initialization completed successfully\n");
        Context.ChangeState(new ErrorCheckState());
    }
    
    private Dictionary<ErrorLevels, List<CustomError>> InitErrors()
    {
        return new Dictionary<ErrorLevels, List<CustomError>>()
        {
            {ErrorLevels.Medium,new List<CustomError>()},
            {ErrorLevels.Low,new List<CustomError>()},
            {ErrorLevels.Critical,new List<CustomError>()}
        };
    }
}