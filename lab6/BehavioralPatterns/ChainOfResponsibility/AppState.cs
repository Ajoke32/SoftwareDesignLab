using System;

namespace BehavioralPatterns.ChainOfResponsibility
{
	public static class AppState
	{
		private static SupportService _supportService;
		public static bool GetState()
		{
			return _supportService.State;
		}
		
		public static void StopService()
		{
			_supportService.Stop();
		}
		public static void SetService(SupportService service)
		{
			_supportService = service;
		}
		
		public static void RestartService()
		{
			_supportService.Restart();
		}
	}
}
