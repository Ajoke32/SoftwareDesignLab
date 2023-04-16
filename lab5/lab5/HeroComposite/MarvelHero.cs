using System;
using lab5.HeroComposite.Abstract;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite
{
	enum HeroType
	{
		EmptyHero,Mage, Warrior, Rogue, Hunter,
		Paladin, Druid, Warlock, Shaman,
	}
	enum Nature
	{
		Kind, Evil, Good, Neutral
	}
	internal class MarvelHero<T> : ContainableEntitetBase<T>,IHero where T:Entitet
	{
		public HeroType Type { get; protected set; }

		public Nature Nature { get; protected set; }
		
		public void SetNature(Nature nature)
		{
		   Nature=nature;	
		}
		
		public void SetHeroType(HeroType type)
		{
			Type = type;
		}
	}

}
