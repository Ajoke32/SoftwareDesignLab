using System;
using BehavioralPatterns.Mediator.CustomEventArgs;

namespace BehavioralPatterns.Mediator.Classes
{
    public delegate void LandingEventHandler(RunwayStateEventArgs e);

    public delegate void TakeOffEventHandler();
    internal class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public event LandingEventHandler OnAircraftLanded;
        public event TakeOffEventHandler OnAircraftTakeOff;
        public void SetUp(Runway[] runways, Aircraft[] aircrafts)
        {
            _aircrafts.AddRange(aircrafts);
            _runways.AddRange(runways);
        }

        public void Notify(object sender, AirEventArgs e)
        {
            var runway = GetRunwayOrExcept(e.RunwayId);
            if (sender is Aircraft)
            {
                if (e.AirState == AirState.Land)
                {
                    TryLand(runway);
                }
                if (e.AirState == AirState.TakeOff)
                {
                    TakeOff(runway);
                }
            }
            if (sender is Runway)
            {
                runway.IsBusyWithAircraft = true;
                runway.HighLightRed();
            }
        }

        private Runway GetRunwayOrExcept(int id)
        {
            var runway = _runways.FirstOrDefault(r => r.Id == id);
            if (runway == null)
            {
                throw new Exception("exp!");
            }
            return runway;
        }

        private void TryLand(Runway runway)
        {
            if (runway.IsBusyWithAircraft)
            {
                OnAircraftLanded.Invoke(new RunwayStateEventArgs() { LandingIsAllowed = false });
            }
            else
            {
                OnAircraftLanded.Invoke(new RunwayStateEventArgs() { LandingIsAllowed = true });
                runway.HighLightRed();
                runway.IsBusyWithAircraft = true;
            }
        }

        private void TakeOff(Runway runway)
        {
            OnAircraftTakeOff.Invoke();
            runway.HighLightGreen();
            runway.IsBusyWithAircraft = false;
        }
    }
}

