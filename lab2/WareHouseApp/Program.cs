using WareHouseApp.Classes;
using WareHouseApp.Managers;

var wareHouse = new WareHouse();

var report = new Reporting();

wareHouse.Manager = new WareHouseManager(wareHouse,report);

wareHouse.Manager.AddProduct(new Product { Name ="A1",Id=1});
wareHouse.Manager.AddProduct(new Product { Name ="A2",Id=12});
wareHouse.Manager.AddProduct(new Product { Name ="A3",Id=4});

wareHouse.Manager.RemoveProduct(4);

report.GetProfitableInvoice();


report.GetExpenseInvoice();
