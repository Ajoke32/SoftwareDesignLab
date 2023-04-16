using System;
using lab5.HeroComposite.Abstract;


namespace lab5.HeroComposite
{
	internal class HeroLogger<E> where E : Entitet
	{

		public void OnArtefactAdded(MarvelHero<E> sender, Entitet e)
		{
			if (sender.IsMainHero)
			{
				System.Console.WriteLine($"Artefact {e.Name} was added to {sender.Name}");
			}
		}

		public void OnArtefactRemoved(MarvelHero<E> sender, Entitet e)
		{
			if (sender.IsMainHero)
			{
				System.Console.WriteLine($"Artefact {e.Name} was removed from {sender.Name}");
			}
		}

	}
}
