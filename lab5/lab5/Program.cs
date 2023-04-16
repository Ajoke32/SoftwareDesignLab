

using lab5.Composite.Clasess;
using lab5.Composite.Composits;
using lab5.Composite.Factory;
using lab5.Composite.Interfaces;
using lab5.HeroComposite;
using lab5.HeroComposite.Abstract;
using lab5.HeroComposite.ArtefactContainers;
using lab5.HeroComposite.Artefacts;
using lab5.HeroComposite.Interfaces;

// // LightHTML
// var tagFactory = new TagFactory();


// var tagComposite = new TagComposite();

// var node1 = (LightElementNode)tagFactory.CreateElement("div", new Dictionary<string, string>()
// {
// 	{"class","center mg"},
// 	{"id","1"}
// });
// var node2= (LightElementNode)tagFactory.CreateElement("div", new Dictionary<string, string>()
// {
// 	{"class","wrapper"},
// 	{"id","12"}
// });

// var img = (LightElementNode)tagFactory.CreateElement("img", new Dictionary<string, string>()
// {
// 	{"class","img"},
// 	{"id","15"}
// });
// var p = (LightElementNode)tagFactory.CreateElement("p");
// var p2 = (LightElementNode)tagFactory.CreateElement("p");
// p2.AppendChild(tagFactory.CreateTextNode("text"));
// p.Parent=(LightElementNode)tagFactory.CreateElement("div");

// p.AppendChild(p2);
// node1.AppendChild(node2);
// node2.AppendChild(p);
// tagComposite.AddChild(node1);
// tagComposite.AddChild(img);
// tagComposite.Display();

// // LightHTML




// Change request: Heroes should support the addition of Containable
// Change class ArtefactContainer<A> :IContainable<A> where A : Artefact
// to class ArtefactContainer<A> :Entitet, IContainable<A> where A : Artefact

var g  = new GloveOfPower<Artefact>();

var builder = new EntitetBuilder();
var hero = builder.SetEntitet<MarvelHero<Entitet>>(new MarvelHero<Entitet>())
.SetName("BlackWidow").SetWeight(50).SetNature<MarvelHero<Entitet>,Entitet>(Nature.Kind)
.AddArtefact<MarvelHero<Entitet>,Entitet>(g)
.SetType<MarvelHero<Entitet>,Entitet>(HeroType.Warrior)
.GetBuilded<MarvelHero<Entitet>>();

// System.Console.WriteLine(hero.GetCount());
System.Console.WriteLine(hero.Type);
System.Console.WriteLine(hero.Nature);
/*
hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();*/

/*
hero.RemoveArtefact(ring);
hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();*/

//var comp =  new CompositeArtefact();

//comp.AddArtefact(ring);

//BlackWidow.Strike();
//System.Console.WriteLine(BlackWidow.Name);

//BlackWidow.CalculateArtefactsWeight();


//System.Console.WriteLine(comp.GetCount());

/*
System.Console.WriteLine(comp.GetWeight());
System.Console.WriteLine(comp.GetPowerBuf());*/




