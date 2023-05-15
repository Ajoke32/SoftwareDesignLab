





//Examples.EventListenerFeature();

//Examples.LightHTML();


//Examples.HeroComposite();

//Examples.Proxy();


//Examples.FlyWeight();


using System.Threading.Channels;
using lab5;
using lab5.Command;
using lab5.Composite.Clasess;
using lab5.Composite.Factory;
using lab5.Composite.Interfaces;

// var tagFactory = new TagFactory();
// var node = (LightElementNode)tagFactory.CreateElement("div",new Dictionary<string, string>()
// {
// 	{"style","color:red; background-coloasdsar:yellow;"}
// });
// var textNode = tagFactory.CreateTextNode("some text");
// var node2 = tagFactory.CreateElement("p");
// node.AppendChild(textNode);
// node.AppendChild(node2);
// node.RemoveChild(node2);
// node.RemoveChild(textNode);
// Examples.Template((LightTextNode)textNode);
// Examples.Template(node);
// Examples.Template((LightElementNode)node2);
// System.Console.WriteLine(node.Display());


//Examples.Interator();

var nodes = new List<ILightNode>()
{
    new LightElementNode("div", ClosureType.Patrial, ViewType.Block),
    new LightElementNode("div", ClosureType.Patrial, ViewType.Block),
    new LightElementNode("p", ClosureType.Patrial, ViewType.Block),
    new LightElementNode("div", ClosureType.Patrial, ViewType.Block),

};
var ed = new Editor(nodes);
foreach (var node in nodes)
{
    Console.WriteLine(node.Display());
}
ed.Start();




