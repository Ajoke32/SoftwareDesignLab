using System;
using lab5.HeroComposite.Abstract;

namespace lab5.HeroComposite
{
	internal class CompositeArtefact
	{
		private List<Entitet> _children;

		public CompositeArtefact()
		{
			_children = new List<Entitet>();
		}
		 public void AddChild(Entitet entitet)
        {
            _children.Add(entitet);
        }

        public void RemoveChild(Entitet entitet)
        {
            _children.Add(entitet);
        }

        public  int GetWeight()
        {
            return _children.Aggregate(0, (current, entitet) => current += entitet.GetWeight());
        }

        public  int GetPower()
        {
            return _children.Aggregate(0, (current, entitet) => current += entitet.GetPower());
        }
        public  int GetCount()
        {
            return _children.Aggregate(0, (current, entitet) => current += entitet.GetCount());
        }
		
		
	}
}
