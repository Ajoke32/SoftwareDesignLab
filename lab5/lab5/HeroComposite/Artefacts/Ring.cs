using System;
using lab5.HeroComposite.Abstract;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite.Artefacts
{
	internal class Ring : Artefact
	{
		public Ring()
		{
			Name="Ring";
			Power=5;
			Weight=20;
		}
	}
}
