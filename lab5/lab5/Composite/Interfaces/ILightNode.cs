using lab5.Composite.Clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Interfaces
{
	internal interface ILightNode
	{
		public string Display();

		public ViewType ViewType { get; }
		
		public LightElementNode Parent { get;set;}
		
	}
	

}
