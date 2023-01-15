


string kurs1 = "Yazılım geliştirici yetiştirme kampı";
string kurs2 = "Programlamaya başlangıç temel kurs";
string kurs3 = "Java kursu";

// array - dizi 

string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
    "Programlamaya başlangıç temel kurs", "Java kursu" ,"c# kursu"};


for (int i = 0; i < kurslar.Length; i=i+1)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For bitti");


foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("Foreach bitti");

