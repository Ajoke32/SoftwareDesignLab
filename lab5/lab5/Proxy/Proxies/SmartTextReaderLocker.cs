using System;
using System.Text.RegularExpressions;
using lab5.Proxy.Classes;
using lab5.Proxy.Interfaces;

namespace lab5.Proxy.Proxies
{
	public class SmartTextReaderLocker : ISmartTextReader
	{
		private Regex _regex;
		private string[,] _resultArray = { };
		private ISmartTextReader _smartTextReader;
		
		public SmartTextReaderLocker(string regex)
		{
			_regex = new Regex(regex);
			_smartTextReader = new SmartTextReader();
		}

		public string[,] Read(string path)
		{
			MatchCollection matches = _regex.Matches(path);
			if(matches.Count>0)
			{
				System.Console.WriteLine("Access denied");
			}else
			{
				var res = _smartTextReader.Read(path);
				_resultArray = new string[res.Length - 1, 0];
				System.Console.WriteLine("The file was successfully read");
			}
			return  _resultArray;
		}
	}
}
