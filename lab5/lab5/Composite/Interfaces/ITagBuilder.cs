using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string TagToString();
    }
}
