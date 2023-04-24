using System;
using BehavioralPatterns.Mediator.CustomEventArgs;

namespace BehavioralPatterns.Mediator.Classes
{
	class Aircraft
	{
		public string Name;

		private CommandCentre _centre;
		public bool IsTakingOff { get; set; }
		
		private int _currentRunway;
		public Aircraft(string name, CommandCentre centre)
		{
			this.Name = name;
			_centre = centre;
		}
		public void LandRequest(int runwayId)
		{
			_centre.OnAircraftLanded += OnLand;
			_centre.Notify(this, new AirEventArgs()
			{
				RunwayId = runwayId,
				AirState = AirState.Land
			});
			_centre.OnAircraftLanded -= OnLand;
			_currentRunway = runwayId;
		}
		private void OnLand(RunwayStateEventArgs e)
		{
			Console.WriteLine($"Aircraft {this.Name} is landing.");
			Console.WriteLine($"Checking runway.");
			if (e.LandingIsAllowed)
			{
				Console.WriteLine($"Aircraft {this.Name} has landed.");
			}
			else
			{
				Console.WriteLine($"Could not land, the runway is busy.");
			}
		}

		public void TakeOff()
		{
			_centre.OnAircraftTakeOff += OnTakeOff;
			_centre.Notify(this, new AirEventArgs() {AirState = AirState.TakeOff, RunwayId=_currentRunway});
			_centre.OnAircraftTakeOff -= OnTakeOff;
		}
		private void OnTakeOff()
		{
			//Console.WriteLine($"Aircraft {this.Name} is taking off.");
			Console.WriteLine($"Aircraft {this.Name} has took off.");
		}
	}
}
