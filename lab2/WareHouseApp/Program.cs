using WareHouseApp.Classes;
using WareHouseApp.Managers;
using WareHouseApp.Stores;

var wareHouse = new WareHouse();

var store = new Store();


var report = new Reporting(store);

var jsonReport  = new JsonReporting(store);



//Менеджер складу може працювати окремо від класу WareHouse, тому що в кострукторі обов'яковми параметрами передається конретний склад
wareHouse.Manager = new WareHouseManager(wareHouse,report);




wareHouse.Manager.AddProduct(new Product {
    Name ="Lenovo N12 G23 Ulta B",Id=1,
    Price = new Euro(),
    Category = new Category() { Id=2,Name="Laptop"}
});;
wareHouse.Manager.AddProduct(new Product {
    Name ="George Orwell 1984", Id=12,
    Arrivas = new DateTime(2023,05,17),
    Price = new Dollar(),
    Unit = "pcs",
    Category = new Category()
    {
        Id = 1,
        Name="Book"
    }
});

wareHouse.Manager.AddProduct(new Product { Name = "Morshinska",Price = new Dollar(), Id = 4, Category = new Category() { Id = 4, Name = "Water" } });




report.GetProductCount();

wareHouse.Manager.RemoveProduct(4);

report.GetProductCount();

report.GetProfitableInvoice();

// тут отримаємо репорт у HTML форматі
report.GetExpenseInvoice();
