using System;

namespace BehavioralPatterns.ChainOfResponsibility.Handlers
{
	public class AccountInfoHandler : ISupportRequestHandler
	{
		private RequestDelegate _next;
		public AccountInfoHandler(RequestDelegate next)
		{
			_next = next;
		}
		public void Handle(SupportContext context)
		{
			if(context.Request!=null&&int.Parse(context.Request)==1)
			{
				System.Console.WriteLine("Name: Mike\nAge: 15\nContractId: 1231aseqwe\nAddress: str.Uk newasc");
			}
			_next(context);
		}
	}
}
