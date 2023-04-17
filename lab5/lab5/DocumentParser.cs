using System;
using System.Text;
using lab5.Composite.Clasess;
using lab5.Composite.Factory;
using lab5.Composite.Interfaces;

namespace lab5
{
	public class DocumentParser : IDocumentParser
	{
		private ILightNode _node;
		private string _path;

		private TagFactory _tagBuilder;
		private StringBuilder _strBuilder = new StringBuilder();
		public DocumentParser(string path)
		{
			_path = path;
			_tagBuilder = new TagFactory();
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
					CreateAndSetText("h1", result[i]);
					_strBuilder.Append(_node.Display());
					continue;
				}
				if (this.IsH2(result[i]))
				{
					CreateAndSetText("h2", result[i]);
					_strBuilder.Append(_node.Display());
					continue;
				}

				if (this.IsBlockquote(result[i]))
				{
					CreateAndSetText("blockquote", result[i]);
					_strBuilder.Append(_node.Display());
					continue;
				}

				CreateAndSetText("p", result[i]);
				_strBuilder.Append(_node.Display());
			}

			return _strBuilder.ToString();
		}

		private void CreateAndSetText(string name, string text)
		{
			_node = _tagBuilder.CreateElement(name);
			((LightElementNode)_node).AppendChild(this.CreateText(text));
		}
	}
}
