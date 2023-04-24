using System;
using BehavioralPatterns.ChainOfResponsibility.Handlers;

namespace BehavioralPatterns.ChainOfResponsibility.Facories
{
	public static class ServiceFactory
	{
		public static ISupportRequestHandler Create<T>(RequestDelegate d)where T : ISupportRequestHandler
		{
			if(typeof(T)==typeof(ErrorrHandler))
			{
				return new ErrorrHandler(d);
			}
			if(typeof(T)==typeof(AccountInfoHandler))
			{
				return new AccountInfoHandler(d);
			}
			if(typeof(T)==typeof(ChangePasswordHandler))
			{
				return new ChangePasswordHandler(d);
			}
			if(typeof(T)==typeof(StateHandler))
			{
				return new StateHandler(d);
			}
			if(typeof(T)==typeof(AccountMoneyHandler))
			{
				return new AccountMoneyHandler(d);
			}
			throw new Exception("This service not exist or not configured properly");
		}
	}
}
