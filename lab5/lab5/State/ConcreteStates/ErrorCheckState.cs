using System.Runtime.InteropServices.JavaScript;
using lab5.State.Enums;

namespace lab5.State.ConcreteStates;

internal class ErrorCheckState:State
{
    private readonly string _defaultPath = Directory.GetCurrentDirectory() + "//State//Uploaded.txt";
    public override void Handle()
    {
        Console.WriteLine("Checking for errors...");
        
        if (IsFileEmpty(Context.ConvertFrom))
        {
            Console.WriteLine("Convert content is empty");
        }

        if (new FileInfo(Context.SavePath).Extension != ".txt")
        {
            Context.Errors?[ErrorLevels.Critical].Add(new CustomError()
            {
                Code = 205,
                Message = "Converting fail, file format must be txt. Update program to pro",
                ErrorLevel = ErrorLevels.Critical
            });
        }
        
        HandlePathError();
        HandleFileExistingError();
        
        if (Context.Errors?.Count > 0)
        {
            if (GetErrorsReport())
            {
                return;
            }
        }

        Console.WriteLine("Ready to upload!");
        var uploadState = new UploadState();
        uploadState.SetDocumentParser(new FlyDocumentParser(Context.ConvertFrom));
        Context.Handle(uploadState);
    }


    private bool GetErrorsReport()
    {
        var criticalErrors = false;
        
        Console.WriteLine("Errors checking result:");
            
        foreach (var e in Context.Errors?.Values.SelectMany(list => list)!)
        {
            if (e.ErrorLevel == ErrorLevels.Critical)
            {
                criticalErrors = true;
            }
            Console.WriteLine($"{e.Message}\nStatus code: {e.Code}\nError level {e.ErrorLevel}");
        }

        return criticalErrors;
    }

    private bool IsFileEmpty(string filePath)
    {
        if (new FileInfo(filePath).Length >= 0) return false;
        
        Context.Errors?[ErrorLevels.Medium].Add(new CustomError()
        {
            Code = 50,
            Message = "File is empty",
            ErrorLevel = ErrorLevels.Medium
        });
        return true;

    }
    private void HandlePathError()
    {
        if (string.IsNullOrEmpty(Context.SavePath))
        {
            Context.Errors?[ErrorLevels.Low].Add(new CustomError()
            {
                Code = 104,
                Message = "The file path is set by default, you can specify it",
                ErrorLevel = ErrorLevels.Low
            });
            Context.SavePath = _defaultPath;
        }
    }
    private void HandleFileExistingError()
    {
        if (!File.Exists(Context.SavePath))
        {
            File.Create(_defaultPath);
            Context.Errors?[ErrorLevels.Medium].Add(new CustomError()
            {
                Code = 100,
                Message = "The file already exists, it will be overwritten",
                ErrorLevel = ErrorLevels.Medium
            });
        }
    }
}