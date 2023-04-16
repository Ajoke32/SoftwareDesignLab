using System;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite.Abstract
{
    internal class ContainableArtefactBase<D> : Artefact, IArtefactContainable<D> where D:Artefact
	{
		private List<D> _artefacts;
		public void AddArtefact(D artefact)
		{
			_artefacts.Add(artefact);
		}

		public void RemoveArtefact(D artefact)
		{
			_artefacts.Add(artefact);
		}
	}
}
