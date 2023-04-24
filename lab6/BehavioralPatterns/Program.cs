


using BehavioralPatterns.ChainOfResponsibility;
using BehavioralPatterns.ChainOfResponsibility.Handlers;
using BehavioralPatterns.Mediator.Classes;

// var supportService = new SupportService();

// AppState.SetService(supportService);

// supportService.UseHandler(next=>context=>
// {
// 	System.Console.WriteLine(context.Menu);
// 	context.Request = Console.ReadLine();
// 	next(context);
// });
// supportService.RegisterSupportService<ErrorrHandler>()
// 	.RegisterSupportService<AccountInfoHandler>()
// 	.RegisterSupportService<ChangePasswordHandler>()
// 	.RegisterSupportService<StateHandler>()
// 	.RegisterSupportService<AccountMoneyHandler>();
// supportService.UseHandler(next=>context=>
// {
// 	if(context.RequestToInt()==3)
// 	{
// 		System.Console.WriteLine(DateTime.Now);
// 	}
// 	next(context);
// });
// Можна впихнути в кінець handler, який запитає чи потрбіно повернутися до меню ще раз, а не завершувати програму
// Але відповідно до завдання потрібно знайти потрібно Handler та завершити 

// також можна робити щось в залежності від context, можна написати покрокову авторизацію, але це займе багато часу
// та нескінченну реєєстрію цепочки
// supportService.UseHandler((next)=>context=>
// {
// 	context.StatusCode=404;
// 	next(context);
// });
// supportService.UseHandler((next)=>context=>
// {
// 	if(context.StatusCode==404)
// 	{
// 		System.Console.WriteLine("Not found");
// 	}else
// 	{
// 		System.Console.WriteLine("Wait..");
// 	}
// });

// supportService.Start();


var cc = new CommandCentre();
var ai = new Aircraft[]{new Aircraft("A1",cc),new Aircraft("A2",cc),new Aircraft("A3",cc)};
var rw =  new  Runway[]{new Runway(cc){Id=1},new Runway(cc){Id=2},new Runway(cc){Id=3}};
cc.SetUp(rw,ai);

ai[0].LandRequest(1);
ai[1].LandRequest(1);
ai[0].TakeOff();
ai[2].LandRequest(1);

// rw[0].TechnicalWork();
// ai[0].LandRequest(1);


