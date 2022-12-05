using System;

namespace degiskenler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b =5;  // 1 byte
sbyte a =5; // 1 byte

short B = 5;   // 2 byte
ushort s = 5;  // 2 byte

Int16 i16 =5;   // 2 byte
int t = 5;      // 4 byte
Int32 i32 = 5;  // 4 byte
Int64 i64 = 5;  // 8 byte
uint y =5;      // 4 byte

long L =5;      // 8 byte
ulong l = 5;    // 8 byte

//REEL SAYILAR
float f = 5;    // 4 byte
double d = 5;   // 8 byte
decimal de = 5; // 16 byte

char c = 'c';           // 2 byte
string str = "elf";     // SINIRSIZ :O

//bool b1 = true;
//bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o1 = "o";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

string str1 = string.Empty;
str1 = "recoo";
string name = "reco";
string surname = "yıld";
string fullName = name + " " + surname;

// Degisken donusumleri
string str20 = "20";
int int20 = 20;
string newValue = str20 + int20.ToString();
Console.WriteLine(newValue); // 2020 çıktısı

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);  //40 çıktısı

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22);  //40 çıktısı

string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime);

string dateTime1 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dateTime1);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);
        }
    }
}