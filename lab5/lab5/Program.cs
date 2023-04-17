using System.Diagnostics;
using lab5;
using lab5.Composite.Clasess;
using lab5.Composite.Composits;
using lab5.Composite.Factory;
using lab5.Composite.Interfaces;
using lab5.FlyWeight.Classes;
using lab5.HeroComposite;
using lab5.HeroComposite.Abstract;
using lab5.HeroComposite.ArtefactContainers;
using lab5.HeroComposite.Artefacts;
using lab5.HeroComposite.Interfaces;
using lab5.Proxy.Classes;
using lab5.Proxy.Proxies;

// // LightHTML
/*
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
tagComposite.Display();*/
/*
<div class='center mg' id='1'>
		<div class='wrapper' id='12'>
				<p>
						<p>
						text
						</p>
				</p>
		</div>
</div>
<img class='img' id='15'/>
*/
// LightHTML




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

/*
string path = Directory.GetCurrentDirectory()+"//Proxy//Password_admin.txt";

var locker = new SmartTextReaderLocker("admin");
locker.Read(path);

path+="error";

var checker = new SmartTextChecker(new SmartTextReader());
checker.Read(path);

path = path.Replace("error","");

var reader = new SmartTextReader();
reader.Read(path);*/


/*
var flyDoc = new FlyDocumentParser($"{Directory.GetCurrentDirectory()}//Proxy//Password_admin.txt");

flyDoc.Render();

long size = System.GC.GetTotalMemory(true);

Process proc = Process.GetCurrentProcess();
Console.WriteLine($"Allocated Private Memory: {proc.PrivateMemorySize64.ToSmallestFullSize()}");
Console.WriteLine($"Physical Memory Usage: {proc.WorkingSet64.ToSmallestFullSize()}");

Console.WriteLine("FlySize: " + size/(1024.0 * 1024.0)+" MB");*/


/*
var defaultDoc = new DocumentParser($"{Directory.GetCurrentDirectory()}//Proxy//Password_admin.txt");

defaultDoc.Render();

long size2 = System.GC.GetTotalMemory(true);
Process proc = Process.GetCurrentProcess();
Console.WriteLine($"Allocated Private Memory: {proc.PrivateMemorySize64.ToSmallestFullSize()}");
Console.WriteLine($"Physical Memory Usage: {proc.WorkingSet64.ToSmallestFullSize()}");
Console.WriteLine("DefaultSize: " + size2 / (1024.0 * 1024.0) + " MB");*/

/*
Allocated Private Memory: 19.02 MB
Physical Memory Usage: 31.59 MB
FlySize: 4.5618438720703125 MB

PS C:\Users\bekke\source\repos\SoftwareDesignLab\lab5\lab5> dotnet run

Allocated Private Memory: 19.56 MB
Physical Memory Usage: 32.23 MB
DefaultSize: 4.562080383300781 MB
///
Allocated Private Memory: 25.91 MB
Physical Memory Usage: 38.38 MB
FlySize: 9.032005310058594 MB

PS C:\Users\bekke\source\repos\SoftwareDesignLab\lab5\lab5> dotnet run

Allocated Private Memory: 26.06 MB
Physical Memory Usage: 38.70 MB
DefaultSize: 9.190437316894531 MB*/










