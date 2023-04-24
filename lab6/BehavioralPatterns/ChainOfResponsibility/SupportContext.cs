using System;

namespace BehavioralPatterns.ChainOfResponsibility
{
	public class SupportContext
	{
		public string? Description{get;set;}
		
		public string? Request {get;set;}
		
		public List<int> AvailableSerivices {get;set;} = new List<int>(){1,2,3,4,5,6};
		
		public int StatusCode {get;set;}
		
		public string? Menu {get;set;}
		
		public int RequestToInt()
		{
			return int.Parse(Request);
		}
		public void WriteMessage(string msg)
		{
			System.Console.WriteLine(msg);
		}
	}
}
