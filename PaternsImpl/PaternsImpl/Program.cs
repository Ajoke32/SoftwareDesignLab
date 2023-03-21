using PaternsImpl;
using PaternsImpl.AbsctractFactoryMethod;
using PaternsImpl.AbsctractFactoryMethod.Factories;
using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using PaternsImpl.Builder;
using PaternsImpl.FactoryMethod.Apps;
using PaternsImpl.FactoryMethod.Classes;
using PaternsImpl.FactoryMethod.CustomEventArgs;
using PaternsImpl.FactoryMethod.Entities;
using PaternsImpl.FactoryMethod.Interfaces;
using PaternsImpl.FactoryMethod.Repositories;
using PaternsImpl.Prototype;
using PaternsImpl.Singletone;


/*
var subFactory = new SubscribeFactory();

var store = new Store();

store.Subscribes.Add(subFactory.CreateSubscribe(1));
store.Subscribes.Add(subFactory.CreateSubscribe(2));
store.Subscribes.Add(subFactory.CreateSubscribe(3));

var repo = new SubscribeRepository(store);

var manager = new SubsсriptionManager(repo);

var appFactory =  new AppFactory();

store.Users.Add(new User() { Id = 1, Name = "John" });


Console.WriteLine("1.Enter to mobile app 2.Enter to website 3.Call to manager");
string? choice = Console.ReadLine();

switch (choice)
{
    case "1": {
            MobileApp mobileApp = (MobileApp)appFactory.CreateApp("MobileApp", manager);
            mobileApp.Run();
            mobileApp.InitUser(store.Users.First());
            mobileApp.ShowInterface();
        }
       break;
    case "2":
        {
            WebSite webApp = (WebSite)appFactory.CreateApp("WebSiteApp", manager);
            webApp.Run();
        }
        break;
    case "3":
        {
            ManagerCall app = (ManagerCall)appFactory.CreateApp("ManagerCall", manager);
            app.Run();
        }
        break;
    default: throw new Exception("App does not exist");
}
*/

/*
Console.WriteLine("1.Mens clothes 2.WomanClothes 3.ChildClothes");
var st = Console.ReadLine();

IClothesFactory? factory = null;

switch (int.Parse(st))
{
    case 1:factory = new MensClothesFactory();
     break;
    case 2:
        factory = new WomansClotherFactory();
     break;
    case 3:
        factory = new ChildClothesFactory();
     break;
}

var app = new App(factory);
Console.WriteLine("1.Create t-shirt 2.Create pants 3.Create socks");
var clothes = Console.ReadLine();

switch (int.Parse(clothes))
{
    case 1:
        app.CreateTshirt();
        app.PrintTshirtInfo();
        break;
    case 2:
        app.CreateTrousers();
        app.PrintTrousersInfo();
        break;
    case 3:
        app.CreateSocks();
        app.PrintSocksInfo();
        break;
}

*/



/*
var inst1 = DatabaseRepository.GetInstance();
var inst2 = DatabaseRepository.GetInstance();

if(inst1 == inst2)
{
    Console.WriteLine("The same instance");
}


var thr = new Thread(() =>
DatabaseRepository.GetInstance()
);

thr.Start();

DatabaseRepository.GetInstance();*/



/*
var parent = new Virus(20, 15, "Ademona", "AF4");

var virus2 = new VirusChild(10, 4, "Lomeno", "RF202", DateTime.Now,parent);

var virus3 = (VirusChild)virus2.Clone();

var virus4 = (Virus)parent.Clone();

var virus5 = (VirusChild)virus3.Clone();

Console.WriteLine(virus5.Parent.Name);

Console.WriteLine(virus4.Name);

parent.AddVirus(virus2);
parent.AddVirus(virus3);
parent.AddVirus(virus4);
parent.AddVirus(virus5);
*/


int[] arr = {8,4,6};

var director = new BuilderDirector(new EnemyBuilder());

var director2 = new BuilderDirector(new HeroBuilder());

Life enemy = director.GetLifeBasicSet();

MyPersonality pers = director2.GetPeronalityBasicSet();
Console.WriteLine($"{pers.HairColor} ---- {enemy.HairColor}");


while (enemy.GetLifeTime()!=0)
{
    int rand = new Random().Next(0, 3);
    Console.WriteLine($"Press button {arr[rand]}");
    var key = Console.ReadLine();
    if (int.Parse(key) == arr[rand])
    {
        Console.WriteLine($"Ememy hp -{pers.GetDamage()}");
        int lf = enemy.GetLifeTime()-20;
        enemy.SetLifeTime(lf);
    }
    else
    {
        Console.WriteLine("Miss");
    }
}
















