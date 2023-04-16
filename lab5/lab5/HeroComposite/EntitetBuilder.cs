using System;
using lab5.HeroComposite.Abstract;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite
{
	internal class EntitetBuilder
	{
		private  Entitet _entitet;
		
		public  EntitetBuilder SetEntitet(Entitet entitet)
		{
			_entitet = entitet;
			return this;
		}
		public  EntitetBuilder SetName(string name)
		{
			_entitet.SetName(name);
			return this;
		}
		public EntitetBuilder SetWeight(int weight)
		{
			_entitet.SetWeight(weight);
			return this;
		}
		
		public EntitetBuilder SetPower(int power)
		{
			_entitet.SetPower(power);
			return this;
		}
		
		public EntitetBuilder SetType<V,K>(HeroType type) where V : MarvelHero<K> where K : Entitet
		{
			((V)_entitet).SetHeroType(type);
			return this;
		}
		public EntitetBuilder IsMain<V,K>(bool IsMain) where V : MarvelHero<K> where K : Entitet
		{
			((V)_entitet).IsMainHero=IsMain;
			return this;
		}
		
		
		public EntitetBuilder SetNature<V,K>(Nature nature) where V : MarvelHero<K> where K:Entitet
		{
			((V)_entitet).SetNature(nature);
			return this;
		}
		
		public EntitetBuilder AddArtefact<V,K>(K artefact) where V : ContainableEntitetBase<K> where K:Entitet 
		{
			((V)_entitet).AddArtefact(artefact);
			return this;
		}
		
		public EntitetBuilder RemoveArtefact<V>(Entitet artefact) where V:ContainableEntitetBase<Entitet>
		{
			((V)_entitet).RemoveArtefact(artefact);
			return this; 
		}
		
		public V GetBuilded<V>() where V : Entitet
		{
			return (V)_entitet;
		}
		
		
	}

}
