// See https://aka.ms/new-console-template for more information


Console.WriteLine("*****Atama ve Islemlı Atama Operatorleri*****");
// Atama Ve Islemlı Atama

int y = 2;
int x = 3;

y= y+2;
Console.WriteLine(y);
y += 3;
Console.WriteLine(y);
y /=1;
Console.WriteLine(y);
x *=2;
Console.WriteLine(x);

Console.WriteLine("*****Mantıksal Operatorler*****");
// Mantıksal Operatorler
// || veya, && ve , ! değilse

bool isSucces = true;
bool isCompleted = false;

if (isSucces && isCompleted)
    Console.WriteLine("Perfect !");

if (isSucces || isCompleted)
    Console.WriteLine("Nice !");

if (isSucces && ! isCompleted)
    Console.WriteLine("Fine !");

Console.WriteLine("*****Ilıskısel Operatorler*****");
// iliskisel operatorler
// < , > , <= , >= , == , !=

int a = 3;
int b = 4;
bool sonuc = a<b;

Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);

Console.WriteLine("*****Aritmetik Operatorler*****");
//Aritmetik Operatorler 
// + , - , * , / 

int sayi1 = 10;
int sayi2 = 5;
int sonuc1= sayi1+sayi2;
Console.WriteLine(sonuc1);
sonuc1= sayi1-sayi2;
Console.WriteLine(sonuc1);
sonuc1= sayi1*sayi2;
Console.WriteLine(sonuc1);
sonuc1= sayi1/sayi2;
Console.WriteLine(sonuc1);
sonuc1 =sayi1++;
Console.WriteLine(sayi1); // sonuc1 yazdırılması gerekiyor ?

// % mod alır (bölümden kalanı gösterir.)
int sonuc2 = 20%3;
Console.WriteLine(sonuc2);