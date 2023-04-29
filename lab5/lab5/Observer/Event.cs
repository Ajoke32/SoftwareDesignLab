using System;
using lab5.Composite.Interfaces;

namespace lab5.Observer
{
	internal class Event
	{
		
		public ILightNode Target{get;private set;}

		public string Type {get;private set;}
		public Event(string type,ILightNode target=null)
		{
			Type = type;
			Target = target;
		}
		
	}
}
