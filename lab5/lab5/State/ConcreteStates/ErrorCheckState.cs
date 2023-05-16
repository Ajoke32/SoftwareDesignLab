using System.Runtime.InteropServices.JavaScript;
using lab5.State.Enums;

namespace lab5.State.ConcreteStates;

internal class ErrorCheckState:State
{
    private readonly string _defaultPath = Directory.GetCurrentDirectory() + "//State//Uploaded.txt";
    public override void Handle()
    {
        Console.WriteLine("Checking for errors...");
        
        if (!File.Exists(Context.ConvertFrom))
        {
            Context.Errors?[ErrorLevels.Critical].Add(new CustomError()
            {
                Code = 205,
                Message = "Cannot start converting, convert file not exist",
                ErrorLevel = ErrorLevels.Critical
            });
        }else if(IsFileEmpty(Context.ConvertFrom))
        {
            Context.Errors?[ErrorLevels.Low].Add(new CustomError()
            {
                Code = 205,
                Message = "Convert file is empty",
                ErrorLevel = ErrorLevels.Low
            });
        }
        HandlePathError();
        HandleFileExistingError();
        if (new FileInfo(Context.SavePath).Extension != ".txt")
        {
            Context.Errors?[ErrorLevels.Critical].Add(new CustomError()
            {
                Code = 205,
                Message = "Converting fail, file format must be txt. Update program to pro",
                ErrorLevel = ErrorLevels.Critical
            });
        }

        if (Context.Errors?.Count > 0)
        {
            if (GetErrorsReport())
            {
                return;
            }
        }

        Console.WriteLine("Ready to upload!\n");
        Context.ChangeState(new UploadState(new FlyDocumentParser(Context.ConvertFrom)));
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
            ConsoleColorChanger.ChangeColor($"{e.Message}\nStatus code: {e.Code}\nError level: {e.ErrorLevel}\n",e.ErrorLevel);
        }

        return criticalErrors;
    }

    private bool IsFileEmpty(string filePath)
    {
        if (new FileInfo(filePath).Length == 0) return true;
        
        Context.Errors?[ErrorLevels.Medium].Add(new CustomError()
        {
            Code = 50,
            Message = "File is empty",
            ErrorLevel = ErrorLevels.Medium
        });
        return false;

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
        }
        else
        {
            Context.Errors?[ErrorLevels.Medium].Add(new CustomError()
            {
                Code = 100,
                Message = "The save file already exists, it will be overwritten",
                ErrorLevel = ErrorLevels.Medium
            });
        }
    }
}