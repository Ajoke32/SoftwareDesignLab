using System;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite.Abstract
{
	// simple base
	internal class ContainableEntitetBase<E> : Entitet,IContainable<E> where E:Entitet
	{
		private List<E> _entitets;
		
		public ContainableEntitetBase()
		{
			_entitets = new List<E>();
		}

		public void AddArtefact(E entitet)
		{
			_entitets.Add(entitet);
		}

		public void RemoveArtefact(E entitet)
		{
			_entitets.Add(entitet);
		}
	}
	
	

}
