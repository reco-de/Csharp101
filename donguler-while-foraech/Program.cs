// While >> istenilen koşul gerçekleşene kadar döngü devam eder.

// 1 den başlayarak consle a girilen sayıların (girilen sayı da dahil) ortalamasını hesaplayan program.

Console.Write("Lütfen Bir Sayı Giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac ++;
}
Console.WriteLine(toplam/sayi);

// 'a' dan başlayarak z ye kadar alfabeyi yazdıran program 

char character = 'a';
while (character<='z')
{
    Console.Write(character);
    character ++ ;

}

//Foreach

string [] arabalar = {"bmw","toyota","volvo"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}