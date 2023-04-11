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
    internal class LigthELementBuilder : ITagBuilder
    {
        private LightElementNode _node;

        private TagFactory _tagFactory;
        private StringBuilder _strBuilder;
        public LigthELementBuilder()
        {
            _tagFactory= new TagFactory();
            _strBuilder = new StringBuilder();
            Reset();
        }

        public ITagBuilder SetNode(LightElementNode node)
        {
            _node = node;
            return this;
        }
        public void Reset()
        {
            _node = new LightElementNode();
        }

        public ITagBuilder SetAttributres()
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
                _strBuilder.Append("\n" + node.Display() + "\n");
            }
            return this;
        }

        public ITagBuilder SetCloseBracket()
        {

            _strBuilder.Append("</");
            _strBuilder.Append(_node.Name);
            _strBuilder.Append(">");
            return this;
        }

        public ITagBuilder SetOpenBracket()
        {
            _strBuilder.Append("<");
            _strBuilder.Append(_node.Name);
            _strBuilder.Append(">");
            return this;
        }

        public string TagToString()
        {
            Reset();
            return _strBuilder.ToString();
        }
    }
}
