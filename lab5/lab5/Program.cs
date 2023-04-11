

using lab5.Composite.Clasess;
using lab5.Composite.Composits;
using lab5.Composite.Factory;

var tagFactory = new TagFactory();


var tagComposite = new TagComposite();

var node1 = (LightElementNode)tagFactory.CreateElement("div", new Dictionary<string, string>()
{
    {"class","center mg"},
    {"id","1"}
});

/*
var img = (LightElementNode)tagFactory.CreateElement("img", new Dictionary<string, string>()
{
    {"class","img"},
    {"id","1"}
});


var node2 = (LightElementNode)tagFactory.CreateElement("p");
node2.AppendChild(node1);
var div = (LightElementNode)tagFactory.CreateElement("div");





div.AppendChild(tagFactory.CreateTextNode("some text"));

*/
node1.AppendChild(tagFactory.CreateElement("div"));
node1.AppendChild(tagFactory.CreateElement("p"));
node1.AppendChild(tagFactory.CreateElement("div"));

tagComposite.AddChild(node1);
//tagComposite.AddChild(img);

tagComposite.Display();