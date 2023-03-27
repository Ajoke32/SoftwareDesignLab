
using PatternsPartTwo;
using PatternsPartTwo.Adapter;
using PatternsPartTwo.Decorator;
using PatternsPartTwo.Decorator.Heroes;
using PatternsPartTwo.Decorator.Items;


/*
var loger = new Logger();

loger.Warn();
loger.Error();
loger.Log();


var adapter = new FileLoggerAdapter(new FileLogger());
adapter.Log();
adapter.Warn();
adapter.Error();*/




//
Hero palldin = new Coat(new Sword(new Palladin()));

//the same coat in another hero
Hero mage = new Staff(new Coat(new Mage()));

//the same coat and sword in another hero
Hero warrior = new Sword(new Coat(new Warrior()));

//Damage must be the same
Console.WriteLine(palldin.Attac());
Console.WriteLine(warrior.Attac());








