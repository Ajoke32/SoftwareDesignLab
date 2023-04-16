using System;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite.Abstract
{
	// simple base
	internal class ContainableEntitetBase<E> : Entitet, IContainable<E> where E : Entitet
	{
		public List<E> _entitets;

		private HeroLogger<E> _logger;
		public ContainableEntitetBase()
		{
			_entitets = new List<E>();
			_logger = new HeroLogger<E>();
		}

		public void AddArtefact(E entitet)
		{
			_entitets.Add(entitet);
			_logger.OnArtefactAdded((MarvelHero<E>)this, entitet);
		}

		public void RemoveArtefact(E entitet)
		{
			_entitets.Add(entitet);
			_logger.OnArtefactRemoved((MarvelHero<E>)this, entitet);
		}

		public override int GetWeight()
		{
			return _entitets.Aggregate(Weight, (current, entitet) => current += entitet.GetWeight());
		}

		public override int GetPower()
		{
			return _entitets.Aggregate(Power, (current, entitet) => current += entitet.GetPower());
		}
		public override int GetCount()
		{
			//if hero is not artefact
			//return _entitets.Aggregate(0, (current, entitet) => current + entitet.GetCount());
			//if hero artefact
			return _entitets.Count;
		}

	}

}
