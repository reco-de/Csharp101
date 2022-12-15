
//Ekrandan Girilen Sayıya Kadar Olan Tek Sayıları Yazdır
Console.WriteLine("Bir Sayı Giriniz?");
int sayac = int.Parse(Console.ReadLine());
for (int i = 1; i < sayac; i++)
{
    if(i%2 ==1)
      Console.WriteLine(i);
}

// 1-1000 Arasındaki Tek Ve Çift Sayıların Toplamı

int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 1000; i++)
{
    if(i % 2 == 1)
        tekToplam += i; // tekToplam = tekToplam + i
    else
        ciftToplam += i; //  ciftToplam = ciftToplam + i
}

Console.WriteLine("Tek Toplam:" + tekToplam);
Console.WriteLine("Çİft Toplam:" + ciftToplam);

// break , continue

for (int i = 1; i < 10; i++)
{
    if(i == 4 )
        break; // istenilen şarta kadar döngüyü devam ettirir.
        Console.WriteLine(i);

}

for (int i = 1; i < 10; i++)
{
    if(i == 4 )
        continue; // istenilen şarta dışında döngüyü devam ettirir.
        Console.WriteLine(i);

}

