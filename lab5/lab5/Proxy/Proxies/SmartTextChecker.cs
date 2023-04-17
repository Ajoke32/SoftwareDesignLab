using System;
using lab5.Proxy.Interfaces;

namespace lab5.Proxy.Proxies
{
	internal class SmartTextChecker : ISmartTextReader
	{
		private string[,] _resultArray = { };
		private ISmartTextReader _smartTextReader;

		private int _symbolCount = 0;
		public SmartTextChecker(ISmartTextReader smartTextReader)
		{
			_smartTextReader = smartTextReader;
		}

		private int GetSymbolsCount()
		{
			foreach (var item in _resultArray)
			{
				_symbolCount += item.Length;
			}
			return _symbolCount;
		}
		public string[,] Read(string fileName)
		{
			try
			{
				var res = _smartTextReader.Read(fileName);
				_resultArray = new string[res.Length - 1, 0];
				System.Console.WriteLine("File opened");
				_resultArray = res;
			}
			catch (Exception e)
			{
				Console.WriteLine("File openning failed with error: " + e.Message);
			}
			finally
			{
				System.Console.WriteLine("File closed");
				System.Console.WriteLine($"Lines read: {_resultArray.Length}, symbols count: {GetSymbolsCount()}");
			}

			return _resultArray;
		}
	}
}
