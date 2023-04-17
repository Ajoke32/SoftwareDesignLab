using System;
using lab5.Composite.Clasess;
using lab5.FlyWeight.Classes.Factories;

namespace lab5
{
    internal static class DocumentParserExtension
    {
        public static LightTextNode CreateText(this IDocumentParser parser, string text)
        {
            return new LightTextNode(text);
        }

        public static bool IsBlockquote(this IDocumentParser parser, string text)
        {
            return text[0]==' ';
        }

        public static bool IsH2(this IDocumentParser parser,string text)
        {
            return text.Length <= 20 && !text.Contains(" ");
        }
    }
}
