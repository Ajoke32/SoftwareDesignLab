using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Interfaces
{
    internal interface ITagBuilder
    {
        public ITagBuilder SetOpenBracket();

        public ITagBuilder SetCloseBracket();

        public ITagBuilder SetAttributres();

        public ITagBuilder SetChilds();

        public void Reset();

        public string TagToString();
    }
}
