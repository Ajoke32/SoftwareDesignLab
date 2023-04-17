using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5.Composite.Clasess;

namespace lab5.Composite.Interfaces
{
	internal interface ITagBuilder
	{
		
		public ITagBuilder SetOpenBrackets();

		public ITagBuilder SetCloseBrackets();

		public ITagBuilder SetCloseBracket();

		public ITagBuilder SetOpenBracket();
		public ITagBuilder SetAttributes();

		public ITagBuilder SetChilds();
		public void Reset();

		public ITagBuilder SetNode(LightElementNode node);
		public string TagToString();
		
		public ITagBuilder SetIdent();
		
		public ITagBuilder SetSlash();
	}
}
