using System;
using BehavioralPatterns.Mediator.Classes;

namespace BehavioralPatterns.Mediator.CustomEventArgs
{
	enum AirState
	{
		Land,
		TakeOff
	}
	internal class AirEventArgs
	{
		public AirState AirState {get;set;}
		
		public int RunwayId {get;set;}
		
	}
}
