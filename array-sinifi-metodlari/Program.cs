//Sort>> Diziler üzerinden sıralama işlemi yapar. Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar.
// Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.


 int[] sayiDizisi = {23,12,4,86,72,3,11,17};

Console.WriteLine("**** Sirasiz Dizi ******");
 foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

Console.WriteLine("**** Sirali Dizi *****");
Array.Sort(sayiDizisi);
 foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Clear>>Dizinin belirtilen elemanlarını varsayılan değerine getirir. 0 yapar.
Console.WriteLine("**** Array Clear *****");
Array.Clear(sayiDizisi,3,1);
 foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Reserve>>Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. 
//Yani dizinin ilk elemanı ile son elemanını yer değiştirir.
Console.WriteLine("**** Array Reserve *****");
Array.Reverse(sayiDizisi);

 foreach (var sayi in sayiDizisi)
  Console.WriteLine(sayi);

//IndexOf>>Verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.
Console.WriteLine("**** Array IndexOf *****");
Console.WriteLine(Array.IndexOf(sayiDizisi,4));

//Resize>>Dizileri yeniden boyutlandırmak için kullanılır.
Console.WriteLine("**** Array Resize *****");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8] = 99 ;

 foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);
    




