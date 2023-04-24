using System;
using BehavioralPatterns.ChainOfResponsibility.Facories;

namespace BehavioralPatterns.ChainOfResponsibility
{
	public delegate void RequestDelegate(SupportContext context);
	public class SupportService
	{
		private List<Func<RequestDelegate, RequestDelegate>> _components = new List<Func<RequestDelegate, RequestDelegate>>();

		public bool State {get;private set;}
		public SupportService UseHandler(Func<RequestDelegate, RequestDelegate> action)
		{
			_components.Add(action);
			return this;
		}

		public SupportService RegisterSupportService<T>() where T : ISupportRequestHandler
		{
			return UseHandler(next => context =>
			{
				var handler = ServiceFactory.Create<T>(next);
				handler.Handle(context);
			});
		}
		private RequestDelegate BuildChain()
		{
			RequestDelegate d = context => { };

			for (int i = _components.Count - 1; i >= 0; i--)
			{
				d = _components[i](d);
			}

			return d;
		}

		public void Stop()
		{
			Environment.Exit(0);
		}
		public void Restart()
		{
			Start();
		}
		public void Start()
		{
			RequestDelegate startDelegate = BuildChain();
			startDelegate.Invoke(new SupportContext()
			{
				Menu = "1.Show account info 2.Change password 3.Remind me of the payment date 4.Replenish the"
				+" account 5.Restart 6.Exit"
			});
		}


	}


}
