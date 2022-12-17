// Dizi Tanımlama
string [] renkler = new string[5];

string [] hayvanlar = {"Kedi","Köpek","Kuş"};

int [] sayi;
sayi= new int[5];

// Diziere Değer Atama 

renkler[0] = "Mavi";
sayi[3] = 10 ;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(sayi[3]);
Console.WriteLine(renkler[0]);

//Döngülerde Dizi Kullanımı 
//Klavyeden girilen n tane sayının ortalamasını hesaplayan program


 Console.Write("Lütfen dizinin eleman sayisini giriniz: ");
 int diziUzunlugu = int.Parse(Console.ReadLine());
 int[] sayiDizisi = new int[diziUzunlugu];

 for (int i = 0; i < diziUzunlugu; i++)
 {
    Console.Write("Lütfen {0}. sayısını giriniz: ", i+1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
 }

 int toplam = 0 ;

 foreach (var sayi1 in sayiDizisi)
 {
    toplam += sayi1;
 }
 
 Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);

