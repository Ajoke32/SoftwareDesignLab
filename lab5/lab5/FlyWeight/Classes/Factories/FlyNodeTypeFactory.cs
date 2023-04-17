using System;
using lab5.Composite.Clasess;
using lab5.Composite.Interfaces;

namespace lab5.FlyWeight.Classes.Factories
{
    internal static class FlyNodeTypeFactory
    {
        private static Dictionary<string, FlyNodeType> _cache = new Dictionary<string, FlyNodeType>();

        //private static Dictionary<string, LightTextNode> _textCache = new Dictionary<string, LightTextNode>();
        public static FlyNodeType CreateElement(string tagName)
        {
            FlyNodeType? node = _cache.GetValueOrDefault(tagName);

            if (node == null)
            {
                node = new FlyNodeType(tagName);
                _cache[tagName] = node;
            }

            return node;
        }

    }
}
