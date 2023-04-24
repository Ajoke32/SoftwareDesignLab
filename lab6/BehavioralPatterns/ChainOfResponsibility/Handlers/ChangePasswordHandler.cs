using System;

namespace BehavioralPatterns.ChainOfResponsibility.Handlers
{
	public class ChangePasswordHandler : ISupportRequestHandler
	{
		private RequestDelegate _next;
		public ChangePasswordHandler(RequestDelegate next)
		{
			_next = next;
		}
		public void Handle(SupportContext context)
		{
			if(context.RequestToInt()==2)
			{
				System.Console.Write("Enter you previous password: ");
				string? res = Console.ReadLine();
				if(IsPasswordMatch(res))
				{
					System.Console.WriteLine("Enter new password");
					string newPass = Console.ReadLine();
					System.Console.WriteLine("Password change sent for processing");
				}else
				{
					System.Console.WriteLine("Password is not match, you can try to change password again");
					AppState.RestartService();
					return;
				}
			}
			_next(context);
		}
		
		private bool IsPasswordMatch(string password)
		{
			if(password!="")
			{
				return true;
			}
			return false;
		}
	}
}
