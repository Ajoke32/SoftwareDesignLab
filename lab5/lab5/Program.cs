

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
var node2= (LightElementNode)tagFactory.CreateElement("div", new Dictionary<string, string>()
{
	{"class","wrapper"},
	{"id","12"}
});

var img = (LightElementNode)tagFactory.CreateElement("img", new Dictionary<string, string>()
{
	{"class","img"},
	{"id","15"}
});
var p = (LightElementNode)tagFactory.CreateElement("p");
var p2 = (LightElementNode)tagFactory.CreateElement("p");
p2.AppendChild(tagFactory.CreateTextNode("text"));
p.Parent=(LightElementNode)tagFactory.CreateElement("div");

p.AppendChild(p2);
node1.AppendChild(node2);
node2.AppendChild(p);
tagComposite.AddChild(node1);
tagComposite.AddChild(img);
tagComposite.Display();

