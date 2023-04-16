using System;
using lab5.HeroComposite.Abstract;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite.ArtefactContainers
{
	internal class GloveOfPower<G> : ArtefactContainer<G> where G:Artefact
	{
		public GloveOfPower()
		{
			AvailableSlots=5;
			ArtefactTypes = new List<string>(){"HealStone","EnergyStone","PowerStone","DefenceStone","SpeedStone"};
		}
		
	}

}
