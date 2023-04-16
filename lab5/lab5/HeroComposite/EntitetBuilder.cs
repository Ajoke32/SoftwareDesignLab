using System;
using lab5.HeroComposite.Abstract;
using lab5.HeroComposite.Interfaces;

namespace lab5.HeroComposite
{
	internal class EntitetBuilder
	{
		private  Entitet _entitet;
		
		public  EntitetBuilder SetEntitet<V>(V entitet) where V : Entitet
		{
			_entitet = (V)entitet;
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
		
		
		public EntitetBuilder SetType<V,K>(HeroType type) where V : MarvelHero<K> where K : Entitet
		{
			((V)_entitet).SetHeroType(type);
			return this;
		}
		
		public EntitetBuilder SetNature<V,K>(Nature nature) where V : MarvelHero<K> where K:Entitet
		{
			((V)_entitet).SetNature(nature);
			return this;
		}
		
		public EntitetBuilder AddArtefact<V,K>(Entitet artefact) where V : ContainableEntitetBase<K> where K:Entitet 
		{
			((V)_entitet).AddArtefact((K)artefact);
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
