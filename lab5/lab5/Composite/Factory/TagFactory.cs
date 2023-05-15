﻿using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Factory
{
	internal class TagFactory
	{
		
		private ILightNode _node;

		public ILightNode CreateElement(string tagName,Dictionary<string,string>? attributes=null)
		{
			switch (tagName)
			{
				case "div":_node = new LightElementNode(tagName, ClosureType.Patrial, ViewType.Block);
					break;
				case "p": _node = new LightElementNode(tagName, ClosureType.Patrial, ViewType.Block);
					break;
				case "img": _node =  new LightElementNode(tagName,ClosureType.Single, ViewType.String);
					break;
				case "h1":_node = new LightElementNode(tagName, ClosureType.Patrial, ViewType.String);
					break;
				case "h2":_node = new LightElementNode(tagName, ClosureType.Patrial, ViewType.String);
					break;
				case "blockquote":_node = new LightElementNode(tagName, ClosureType.Patrial, ViewType.String);
					break;		
				default: throw new Exception("Tag not exist");
				 
			}
			if(attributes!= null)
			{
				var node = (LightElementNode)_node;
				node.SetAttributes(attributes);
				node.State.IsCreated= true;
				return node;
			}
			
			_node.State.IsCreated=true;
			 
			return _node;
		}

		public ILightNode CreateTextNode(string text)
		{
			var textNode = new LightTextNode(text)
			{
				State = {IsCreated = true}
			};
			
			return textNode;
		}
	}
}
