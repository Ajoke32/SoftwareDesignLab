using System;

namespace BehavioralPatterns.ChainOfResponsibility.Handlers
{
	public class AccountMoneyHandler : ISupportRequestHandler
	{
		private RequestDelegate _next;
		
		public AccountMoneyHandler(RequestDelegate next)
		{
			_next = next;
		}
		public void Handle(SupportContext context)
		{
			if(context.RequestToInt()==4)
			{
				System.Console.Write("Enter sum:");
				var res = Console.ReadLine();
				System.Console.WriteLine($"your account is replenished by {res}");
			}
			
			_next(context);
		}
	}
}
