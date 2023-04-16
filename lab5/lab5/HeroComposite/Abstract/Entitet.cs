using System;

namespace lab5.HeroComposite.Abstract
{
	
	internal abstract class Entitet
	{
		public int BasicUnit {get;}=1;
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
			return BasicUnit;
		}
		
		public virtual int GetWeight()
		{
			return Weight;
		}
		
		public virtual int GetPower()
		{
		 	return Power;	
		}
		
	}
}
