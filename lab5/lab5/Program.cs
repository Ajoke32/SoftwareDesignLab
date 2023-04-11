

using lab5.Composite.Clasess;
using lab5.Composite.Composits;
using lab5.Composite.Factory;
using lab5.Composite.Interfaces;

var tagFactory = new TagFactory();


var tagComposite = new TagComposite();

var node1 = (LightElementNode)tagFactory.CreateElement("div", new Dictionary<string, string>()
{
    {"class","center mg"},
    {"id","1"}
});


var img = (LightElementNode)tagFactory.CreateElement("img", new Dictionary<string, string>()
{
    {"class","img"},
    {"id","15"}
});

var node2 = (LightElementNode)tagFactory.CreateElement("p");
node2.AppendChild(node1);
var div = (LightElementNode)tagFactory.CreateElement("div");


div.AppendChild(tagFactory.CreateTextNode("some text"));


node1.AppendChild(div);
node1.AppendChild(tagFactory.CreateElement("div"));
node1.AppendChild(tagFactory.CreateElement("p"));

node1.InsertBefore(div, img);

tagComposite.AddChild(node1);
tagComposite.AddChild(img);

tagComposite.Display();

var copy = (List<ILightNode>)tagComposite.Copy();


LightElementNode treeCopy = (LightElementNode)node1.Clone();

Console.WriteLine(treeCopy.Display());*/