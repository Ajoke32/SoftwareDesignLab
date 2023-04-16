using System;

namespace lab5.HeroComposite.Interfaces
{
    internal interface IArtefactContainable<T> where T:Artefact
	{
		public void AddArtefact(T artefact);
		
		public void RemoveArtefact(T artefact);
	}
}
