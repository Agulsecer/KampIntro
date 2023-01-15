// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,Aşkım Sinem!");

// type safety - 
// do not repeat  yourself
//değer tutucu , alias

string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 18.45;
double dolarBugun = 18.45;



if (dolarDun>dolarBugun) 
{
    Console.WriteLine("Azalış butonu");
    
}
 else if  (dolarDun<dolarBugun)
{ 
    Console.WriteLine("Artış butonu");

}

else
{
    Console.WriteLine("Eşit butonu");
}