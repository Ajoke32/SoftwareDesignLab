using System;
using System.Text;
using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;
using lab5.FlyWeight.Classes;
using lab5.FlyWeight.Classes.Factories;

namespace lab5
{
    internal class FlyDocumentParser :IDocumentParser
    {
        private INodeEditor _node;
        private string _path;

        private StringBuilder _strBuilder = new StringBuilder();
        public FlyDocumentParser(string path)
        {
            _path = path;
        }
        public string Render()
        {
            var result = File.ReadAllLines(_path);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == "")
                {
                    continue;
                }
                if (i == 0)
                {
                    CreateAndSetTextFly("h1",result[i]);
                    _strBuilder.Append(((FlyLightElementNode)_node).Display());
                    continue;
                }
                if (this.IsH2(result[i]))
                {
                    CreateAndSetTextFly("h2",result[i]);
                    _strBuilder.Append(((FlyLightElementNode)_node).Display());
                    continue;
                }

                if (this.IsBlockquote(result[i]))
                {
                    CreateAndSetTextFly("blockquote",result[i]);
                    _strBuilder.Append(((FlyLightElementNode)_node).Display());
                    continue;
                }

                CreateAndSetTextFly("p",result[i]);
                _strBuilder.Append(((FlyLightElementNode)_node).Display());
            }

            return _strBuilder.ToString();
        }

        private void CreateAndSetTextFly(string name,string text)
        {
            _node = new FlyLightElementNode(name);
            _node.AppendChild(this.CreateText(text));
        }
   

    }
}
