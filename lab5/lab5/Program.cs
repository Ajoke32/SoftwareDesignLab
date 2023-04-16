

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




// Change request: Герої повинні уміти містити в собі контейнерні типи
// в проекті вже реалізовано це,шляхом реалізації інтерфейсу IContainable та абстрактоного класу Entitet
// таким чином нова сутність повидить себе як контейнер та як премет, що можна додавати 

// Але взагалі на початку, повинна бути сутність ContainableBase:IContanable, що буде поводити себе виключно як контейнер 
// і вже потім, якщо цей change request прийде реалізовувати ContainableEntiteBase 

// Тепер коли буде ContainableEntiteBase та ContainableBase, GloveOfPower можна буде наслідувати і від того, і від іншого
// та дивитися на його поведіку. (в проекті ContainableBase немає, тут відразу реалізований change request)

// є моживість створення різних героїв та артефактів

//Герой, що може містити в собі інших героїв 
//var h = builder.SetEntitet<MarvelHero<Entitet>>

//Герой, що може містити в собі тільи артефакти
//var h2 = builder.SetEntitet<MartvelHero<Artefact>>

// Герой, що може містити в собі тільки контейнери для артефакті, що не є артефактом або є ним
//var h3 = builder.SetEntitet<MarvelHero<ArtefactContainer<Artefact>>>(new MarvelHero<ArtefactContainer<Artefact>>());

//В артефактів поки що відсутні якісь фічі, але їх додвання буде легким у подальшому 

/*
var builder = new EntitetBuilder();

var ring = new Ring();

var SpiderMan = builder.SetEntitet(new MarvelHero<Entitet>())
.SetName("Spider Man").SetWeight(70).SetPower(100).IsMain<MarvelHero<Entitet>,Entitet>(true)
.AddArtefact<MarvelHero<Entitet>,Entitet>(ring)
.AddArtefact<MarvelHero<Entitet>,Entitet>(new Necklace())
.SetNature<MarvelHero<Entitet>,Entitet>(Nature.Kind)
.GetBuilded<MarvelHero<Entitet>>();

SpiderMan.RemoveArtefact(ring);


var gloveOfPower = builder.SetEntitet(new GloveOfPower<Artefact>())
.SetName("Glove").SetWeight(10).SetPower(5).GetBuilded<GloveOfPower<Artefact>>();

var hero = builder.SetEntitet(new MarvelHero<Entitet>())
.SetName("BlackWidow").SetWeight(50).SetNature<MarvelHero<Entitet>,Entitet>(Nature.Kind)
.AddArtefact<MarvelHero<Entitet>,Entitet>(gloveOfPower)
.AddArtefact<MarvelHero<Entitet>,Entitet>(new Ring())
.AddArtefact<MarvelHero<Entitet>,Entitet>(SpiderMan)
.SetType<MarvelHero<Entitet>,Entitet>(HeroType.Warrior)
.GetBuilded<MarvelHero<Entitet>>();

System.Console.WriteLine(hero.GetCount());
System.Console.WriteLine(hero.GetPower());
System.Console.WriteLine(hero.GetWeight());

var composite = new CompositeArtefact();

composite.AddChild(hero);
System.Console.WriteLine("\n-------------------------------------------------\n");
System.Console.WriteLine(composite.GetCount());
System.Console.WriteLine(composite.GetPower());
System.Console.WriteLine(composite.GetWeight());
*/









