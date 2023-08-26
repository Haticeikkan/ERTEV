using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsol_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {//bu bizim ilk örnek kodlarımız
            /*çok satır açıklama yazarız
             * 
             * 
             */
            /*Console.WriteLine("Merhaba Dünya");
              Console.ReadKey();*/

            //Değişken tanımlama
            /*  int x = 8;
              x = 10;
              Console.WriteLine(x);
              Console.ReadKey();
              String b = "tuncay";
              string og_ad_soyad = "kamil";
              char y = 'u';
              double sayi1 = 67.25;
              bool durum = true;*/

            //Basit 4 işlem
            /* Console.WriteLine("1. Sayıyı giriniz");
            int sayi1= Convert.ToInt32( Console.ReadLine());
             Console.WriteLine("2. sayıyı giriniz");
             int sayi2 = Convert.ToInt32(Console.ReadLine());
             int top = sayi1 + sayi2;
             int fark = sayi1 - sayi2;
             int carpim = sayi1 * sayi2;
             int bolum = sayi1 / sayi2;
             Console.WriteLine("Sayılarımızın toplamı=" + top);
             Console.WriteLine("Sayılarımızın farkı=" + fark);
             Console.WriteLine("Sayılarımızın carpımı=" + carpim+"bolümü="+bolum);
             Console.ReadKey();*/

            /*double sonuc = Math.Pow(3, 5);
            
            Console.WriteLine("Sonuc=" + sonuc);
            Console.ReadKey();*/

            /*int x = 5;
             x = x + 1;//6
             x += 1;
             x *= 3;
             int y = 3;
             y++;//y=y+1
             y--;*/

            int x = 8, y = 5, z = 4;
            bool sonuc = false;  
            sonuc=  x > y;//true
            sonuc = !(x < y) && (z != 3);//true
            sonuc = x == z || y <= 5;
        }
    }
}
