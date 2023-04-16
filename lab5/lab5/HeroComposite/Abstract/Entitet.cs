using System;

namespace lab5.HeroComposite.Abstract
{
	internal interface IEntitet
	{
		public string Name { get;}
		public int Weight { get;}
		public int Power { get;}
		
	}
	internal abstract class Entitet
	{
		public string Name { get;protected set;}
		public int Weight { get; protected set; }
		public int Power { get;protected set; }
		
		public void SetName(string name)
		{
			Name = name;
		}
		
		public void SetWeight(int weight)
		{
			Weight = weight;
		}
		
		public void SetPower(int powerBuf)
		{
			Power = powerBuf;
		}
		
		public virtual int GetCount()
		{
			return 1;
		}
	}
}
