using System;
using lab5.Composite.Interfaces;
using lab5.Composite.States;
using lab5.Observer;

namespace lab5.Composite.Clasess
{
	internal abstract class BaseNode : ILightNode, IEventListener
	{
		protected LightElementNode? _parent = null;

		public LightElementNode? NextElementSibling {get;set;}=null;
		
		public abstract ViewType ViewType { get; }
		private List<Action<Event>> _listeners = new List<Action<Event>>(); // observers
		private List<Event> _events = new List<Event>();
		public ElementState State { get; private set; } = new ElementState();
		public abstract string Name { get; }

		public LightElementNode? Parent
		{
			get => _parent;
			set
			{
				if (value != null && value.HaveChild(this))
				{
					_parent = value;
				}
			}
		}

		public abstract string Display();

		public void AddEventListener(string eventName, Action<Event> listener)
		{
			_listeners.Add(listener);
			_events.Add(new Event(eventName, this));
		}

		public void RemoveEventListener(Action<Event> listener)
		{
			_listeners.Remove(listener);
		}

		public void TriggerEvent(string eventName)  // Notify observers
		{
			for (int i = 0; i < _listeners.Count; i++)
			{
				if (_events[i].Type == eventName)
				{
					_listeners[i](_events[i]);
				}
			}
		}

		public void CleanListeners()
		{
			foreach(var listener in _listeners)
			{
				this.RemoveEventListener(listener);
			}
		}
	}
}
