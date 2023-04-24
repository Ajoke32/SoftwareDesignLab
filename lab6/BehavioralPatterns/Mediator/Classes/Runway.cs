using System;
using BehavioralPatterns.Mediator.CustomEventArgs;

namespace BehavioralPatterns.Mediator.Classes
{
	internal class Runway
	{
		private CommandCentre _centre;
		public int Id {get;set;}
		public bool IsBusyWithAircraft{get;set;}
		public Runway(CommandCentre centre)
		{
			_centre = centre;
		}
		public void TechnicalWork()
		{
			_centre.Notify(this,new AirEventArgs(){RunwayId=Id});
		}
		public void HighLightRed()
		{
			Console.WriteLine($"Runway {this.Id} is busy now");
		}

		public void HighLightGreen()
		{
			Console.WriteLine($"Runway {this.Id} is free!");
		}
	}
}

