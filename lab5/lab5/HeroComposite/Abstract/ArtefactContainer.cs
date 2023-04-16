using System;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite.Abstract
{
	internal abstract class ArtefactContainer<A> :Entitet, IContainable<A> where A : Artefact
	{

		public List<string> ArtefactTypes { get; protected set; }
		public int AvailableSlots { get; protected set; }
		public List<A> Artefacts { get; protected set; }

		public ArtefactContainer()
		{
			ArtefactTypes = new List<string>();
			Artefacts = new List<A>();
		}
		public List<string> GetAvailableArtefactsType()
		{
			return ArtefactTypes;
		}


		public void AddArtefact(A artefact)
		{
			if ((ArtefactTypes.Contains(artefact.Name) && AvailableSlots != 0) || ArtefactTypes.Contains("All"))
			{
				Artefacts.Add(artefact);
				AvailableSlots--;
			}
		}

		public  void RemoveArtefact(A artefact)
		{
			Artefacts.Remove(artefact);
			AvailableSlots++;
		}

	}
}
