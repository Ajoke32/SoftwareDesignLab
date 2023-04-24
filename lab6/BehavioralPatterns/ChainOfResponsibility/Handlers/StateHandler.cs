using System;

namespace BehavioralPatterns.ChainOfResponsibility.Handlers
{
	public class StateHandler:ISupportRequestHandler
	{
		private RequestDelegate _next;
		public StateHandler(RequestDelegate next)
		{
			_next = next;
		}
		public void Handle(SupportContext context)
		{
		   if(context.RequestToInt()==5)
		   {
		   	  AppState.RestartService();
			  return;
		   }
		   if(context.RequestToInt()==6)
		   {
		   	  AppState.StopService();
			  return;
		   }
		   _next(context);
		}
	}
}
