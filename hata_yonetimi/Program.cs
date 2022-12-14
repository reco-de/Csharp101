
/* try  //  Hataya sebebiyet verme ihtimali olan kod
{
 Console.WriteLine("Bir Sayı giriniz");
 int sayi = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Girmiş Olduğunuz Sayı:" + sayi);   
}
catch(Exception ex)  // Hata ile karşılaşıldığında ne yapılacağı buraya yazılır
{
 Console.WriteLine("Hata:" + ex.Message.ToString());   
}
finally // Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız
{
  Console.WriteLine("İşlem Tamamlandı");   
} */

try
{
 // int a = int.Parse(null); 
 // int a = int.Parse("test");
 int a = int.Parse("20000000000");
}
catch (ArgumentNullException ex)
{
  Console.WriteLine("boş değer girdiniz");
  Console.WriteLine(ex);
}
catch (FormatException ex)
{
  Console.WriteLine("Veri tipi Uygun değil");
  Console.WriteLine(ex);
}
catch(OverflowException ex)
{
  Console.WriteLine("Çok küçük ya da çok büyük değer girdiniz.");
  Console.WriteLine(ex);
}
finally{
  Console.WriteLine("İşlem başarı ile tamamlandı.");
}