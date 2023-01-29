// See https://aka.ms/new-console-template for more information
using OOP1;

Console.WriteLine("Hello, World!");


Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 50;
product1.UnitInStock = 20;



Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Sandalye",
    UnitInStock = 5,    UnitPrice = 20 };


ProductManager productManager = new ProductManager();
productManager.Add(product1);

ProductManager productManager2 = new ProductManager();
productManager2.Add(product2);


productManager.Topla2(3,6);


int toplamaSonucu = productManager.Topla(3, 6);

Console.WriteLine(toplamaSonucu + 10);
 
// int ,double,bool .. değer tip
//diziler,class ,abstract class.interface  ... referans tip