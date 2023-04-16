using System;
using lab5.HeroComposite.Abstract;

namespace lab5.HeroComposite
{
	internal class Artefact:Entitet
	{
	
		public void CalculatePowerBuf(MarvelHero<Entitet> hero)
		{
			System.Console.WriteLine("Calculation...");
		}
	}

}
