
using PatternsPartTwo;
using PatternsPartTwo.Adapter;
using PatternsPartTwo.Bridge;
using PatternsPartTwo.Bridge.Figures;
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


/*
var facade = new BigMacFacade();

facade.AllInclusive();

facade.DoubleCheese();

facade.PotatoCheese();*/


var bridge1 = new FigureDrawing(new Square());
var bridge2 =  new FigureDrawing(new Circle());
var bridge3 = new FigureDrawing(new Triangle());

bridge1.VectorDrawing();
bridge1.RasterDrawing();

bridge2.RasterDrawing();
bridge2.RasterDrawing();

bridge3.RasterDrawing();
bridge3.RasterDrawing();
//
var exBridge1 = new ExtendedDrawing(new Square());
var exBridge2 = new ExtendedDrawing(new Circle());
exBridge1.ThreeDimensionDrawing();
exBridge2.ThreeDimensionDrawing();







