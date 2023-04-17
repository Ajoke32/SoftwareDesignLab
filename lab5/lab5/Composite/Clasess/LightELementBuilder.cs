using lab5.Composite.Factory;
using lab5.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab5.Composite.Clasess
{
	internal class LightELementBuilder : ITagBuilder
	{
		private LightElementNode _node;

		private StringBuilder _strBuilder;
		public LightELementBuilder()
		{
			_strBuilder = new StringBuilder();
			_node = new LightElementNode();
		}

		public ITagBuilder SetIdent()
		{
			
			if (_node.Parent != null&&(_node.InnerHtml()!=""||_strBuilder.ToString()==$""))
			{
				_node.Ident = _node.Parent.Ident + 1;
				for (int i = 0; i < _node.Ident; i++)
				{
					_strBuilder.Append("\t");
				}
			}
			return this;
		}
		public ITagBuilder SetNode(LightElementNode node)
		{
			_node = node;

			return this;
		}
		public void Reset()
		{
			_node = new LightElementNode();
			_strBuilder = new StringBuilder();
		}

		public ITagBuilder SetAttributes()
		{
			if (_node.Attributes.Count > 0)
			{
				foreach (var attr in _node.Attributes)
				{
					_strBuilder.Append($" {attr.Key}='{attr.Value}'");
				}
			}
			return this;
		}

		public ITagBuilder SetChilds()
		{
			foreach (var node in _node.Nodes)
			{
				//_strBuilder.Append(node.Display());
				_strBuilder.Append("\n" + node.Display() + "\n");
			}
			return this;
		}

		public ITagBuilder SetCloseBrackets()
		{

			_strBuilder.Append("</");
			_strBuilder.Append(_node.Name);
			_strBuilder.Append(">");
			return this;
		}

		public ITagBuilder SetOpenBrackets()
		{
			_strBuilder.Append("<");
			_strBuilder.Append(_node.Name);
			_strBuilder.Append(">");
			return this;
		}

		public string TagToString()
		{
			var stringBuilder = _strBuilder;
			Reset();
			//return stringBuilder.ToString()+"\n";
			return stringBuilder.ToString();
		}

		public ITagBuilder SetOpenBracket()
		{
			_strBuilder.Append("<");
			_strBuilder.Append(_node.Name);

			return this;
		}

		public ITagBuilder SetSlash()
		{
			_strBuilder.Append("/");
			return this;
		}

		public ITagBuilder SetCloseBracket()
		{
			_strBuilder.Append(">");
			return this;
		}
	}
}
