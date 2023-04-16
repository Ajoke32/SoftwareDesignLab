using System;
using lab5.HeroComposite.Abstract;

namespace lab5.HeroComposite.Interfaces
{
	internal interface IContainable<T> where T:Entitet
	{
		public void AddArtefact(T artefact);
		public void RemoveArtefact(T artefact);	
	}
}
