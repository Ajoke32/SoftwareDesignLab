using System;
using lab5.Composite.Interfaces;

namespace lab5.Composite.Clasess
{
	internal static class LighNodeExtention
	{
		public static bool HaveChild(this LightElementNode node,ILightNode childNode)
		{
			return node.Nodes.Contains(childNode)?true:false;
		}
		
		public static bool IsAppendable(this LightElementNode node)
		{
			return node.ClosureType==ClosureType.Patrial;
		}
	}
}
