
using PatternsPartTwo;
using PatternsPartTwo.Adapter;
using PatternsPartTwo.Decorator;
using PatternsPartTwo.Decorator.Heroes;
using PatternsPartTwo.Decorator.Items;
using PatternsPartTwo.Facade;


/*
var loger = new Logger();

loger.Warn();
loger.Error();
loger.Log();


var adapter = new FileLoggerAdapter(new FileLogger());
adapter.Log();
adapter.Warn();
adapter.Error();*/


/*

//використання декількох екземплярів інвентаря на героях
Hero palldin = new Coat(new Sword(new Palladin()));


Hero mage = new Staff(new Coat(new Mage()));


Hero warrior = new Sword(new Coat(new MagicBall(new Warrior())));


Console.WriteLine(mage.GetDamage());
Console.WriteLine(warrior.GetDamage());
Console.WriteLine(palldin.GetDamage());*/



var facade = new BigMacFacade();

facade.AllInclusive();

facade.DoubleCheese();

facade.PotatoCheese();








