// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Kurs kurs1 = new Kurs();
kurs1.Egitmen = "Engin hoca";
kurs1.IzlenmeOrani = 68;
kurs1.KursAdi = "C#";



Kurs kurs2 = new Kurs();
kurs2.Egitmen = "Anıl gülseçer";
kurs2.IzlenmeOrani = 76;
kurs2.KursAdi = "Java";

Kurs kurs3 = new Kurs();
kurs3.Egitmen = "Sinem";
kurs3.IzlenmeOrani = 88;
kurs3.KursAdi = "Python";

//Console.WriteLine(kurs1.Egitmen + " " + kurs2.Egitmen);


Kurs[] kursliste = new Kurs[] { kurs1, kurs2, kurs3 };

foreach (var kursveritipi in kursliste)
{
    Console.WriteLine(kursveritipi.Egitmen + ":" + kursveritipi.KursAdi);
}

class Kurs
{
    public string KursAdi { get; set; }
    public  string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}

