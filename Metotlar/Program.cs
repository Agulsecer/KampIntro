// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");



// dont repeat yourself  -- DRY   - clean code - best practice 



Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";


Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "diyarbakır karpuzu";



Urun[] urunler = new Urun[] { urun1, urun2 };


// type safe -- tip güvenli
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------------------");



}


Console.WriteLine("--------------metotlar---------------");


//instance -- örnek 
SepetManager sepetmanager = new SepetManager();
sepetmanager.Ekle(urun1);
sepetmanager.Ekle(urun2);

Console.WriteLine("--------------metotlar2---------------");

sepetmanager.Ekle2("Armut", "Yeşil armut", 12);
sepetmanager.Ekle2("Elma", "Yeşil elma", 12);
sepetmanager.Ekle2("Karput", "Diyarbakır karpuzu", 12);




