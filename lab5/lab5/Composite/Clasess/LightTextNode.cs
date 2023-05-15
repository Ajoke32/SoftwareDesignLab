using lab5.Composite.Interfaces;
using lab5.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Clasess
{
	internal class LightTextNode : ELementLifecycle
	{
		protected string Text;
		public override ViewType ViewType { get; }

		public override string  Name {get=>Text;}
		public int Ident { get; set; } = 0;

		public LightTextNode(string text)
		{
			Text = text;
			ViewType = ViewType.String;
		}

		public override string Display()
		{
			var s = new StringBuilder();
			if (Parent != null)
			{
				for (int i = 0; i < Parent.Ident; i++)
				{
					s.Append("\t");
				}
			}
			return s.Append(Text).ToString();
		}

		protected override void OnCreated()
		{
			System.Console.Write("Text node ");
			base.OnCreated();
			System.Console.WriteLine();
		}

		protected override void OnDeleted()
		{
			System.Console.Write("Text node ");
			base.OnDeleted();
			System.Console.WriteLine();
		}
	}
}
