using System;

namespace BehavioralPatterns.ChainOfResponsibility
{

	public class ErrorrHandler : ISupportRequestHandler
	{
		private RequestDelegate _next;
		
		private int _userInput;
		public ErrorrHandler(RequestDelegate next)
		{
			_next = next;
		}

		public void Handle(SupportContext context)
		{
			if(!int.TryParse(context.Request,out _)||context.Request==null)
			{
				System.Console.WriteLine("Incorrect input !");
				AppState.RestartService();
				return;
			}
			_userInput = int.Parse(context.Request);
			if(!context.AvailableSerivices.Contains(_userInput))
			{
				System.Console.WriteLine("This service is not available");
				AppState.RestartService();
				return;
			}
			_next(context);
		}
	}
}
