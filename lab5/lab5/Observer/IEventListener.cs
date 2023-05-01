using System;

namespace lab5.Observer
{
	internal interface IEventListener
	{
		public void AddEventListener(string eventName,Action<Event> listener);
		
		public void RemoveEventListener(Action<Event> listener);
		
		public void TriggerEvent(string eventName);
		
		public void CleanListeners();
	}
}
