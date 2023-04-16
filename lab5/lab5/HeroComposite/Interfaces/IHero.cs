using System;

namespace lab5.HeroComposite.Interfaces
{
    internal interface IHero
    {
        public HeroType Type { get; }

		public Nature Nature { get;}
		
		public void SetNature(Nature nature);
		public void SetHeroType(HeroType type);
    }
}
