using System;

namespace lab5.Composite.States
{
	public class ElementState
	{
		public bool IsCreated {get;set;}
		
		public bool IsRemoved {get;set;}
		
		public bool IsInserted {get;set;}
		
		public bool IsStylesApplied {get;set;}
	}
}
