

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



/// якщо робити контейнер не артефектом, то виходить надлишкове дублювання коду
/// - Наприклад: List<Artefact> artefacts;, далі методи на додавання і видалення, методи для розрахунку
/// 
// - Потім завдання про "Додайте в друзі" не зрозуміле
// - Це повинний бути окремий List<Heros> _friends чи щось інше ?
// - Якщо додати в друзі, то виходить, що і герой вже також Артефакт, або Контейнер 

// - Якщо PowerOfGlow контейнер, а не артефакт, то який від нього сенс в прогамі ?
// - Знову створювати List<Containers> для героя, оскільки герої носять артефакти, а не контейнери ?
// - PowerOfGlove  на інтуїтивному рівні задається річчю, яку можна прицепити на героя, тобто також артефакт
// - Можливо контейнер малось на увазі як стор якийсь, кди можна запихнути артефакти, як в сумку
// - але цю сумку всеодно можна повісити на героя

// - В самому паттерні, особливо в класичному його виді, всі методи викликаються по дереву, від батька до дітей
// - Якщо в героя вже є контейнер, або інший герой, то вони також повинні виконати якийсь спільний Operation() і так далі
// - Я намагався ділити ці сутності, але потім рахувати той самий Count в Composite - просто неможливо
// - тому що операція в Composite одна, а контейнери не артефакти,  а це означає if...else


// Change request: Heroes should support the addition of Containable
//  go to Containable abstract class, and  do this: Containable:Entitet,IContainable
//  now all Containable classes is Entitet, than can be added to List<Entitet>
//sample //

var b = new MarvelHero<Entitet>();
var b2 =  new MarvelHero<Artefact>();
var r = new Ring();

var g = new GloveOfPower<Artefact>();

var builder = new EntitetBuilder();
var hero = builder.SetEntitet<MarvelHero<Artefact>>(new MarvelHero<Artefact>())
.SetName("BlackWidow").SetWeight(50).SetNature<MarvelHero<Artefact>,Artefact>(Nature.Kind)
.AddArtefact<MarvelHero<Artefact>,Artefact>(r)
.SetType<MarvelHero<Artefact>,Artefact>(HeroType.Warrior)
.GetBuilded<MarvelHero<Artefact>>();

// System.Console.WriteLine(hero.GetCount());
System.Console.WriteLine(hero.Type);
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




