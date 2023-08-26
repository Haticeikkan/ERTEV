using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı adı ve şifre kontrol eden basit bir program yazınız. //
            /*Console.WriteLine("kullanıcı adı giriniz");
            string kuladi = Console.ReadLine();
            Console.WriteLine("şifre giriniz");
            string sifre = Console.ReadLine();
            if (kuladi =="admin" && sifre=="12345")
            {//şart sağlanıyorsa true  çalışacak komutlar
                Console.WriteLine("kullanıcı adı şifre doğru giriş yapıldı"); 
            }//if
            else//değilse şart false üretiyse çalışacak kodlar
            {
                Console.WriteLine("kullanıcı adı veya şifre yanlış");
            }

            Console.ReadKey();*/

            // 2 yazılı ve 1 performans notu girilecek . Girilen notların ortalaması 50 ve üzeri ise geçtiniz değilse kaldınız mesajı verilecek ancak girlen not 0-100 arası değilse uyarı verecek ve programı bitirecek. //

            /*Console.WriteLine("Yazılı1 giriniz");
            byte yaz1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Yazılı2 giriniz");
            byte yaz2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("performans giriniz");
            byte perf = Convert.ToByte(Console.ReadLine());
            if (yaz1>=0 && yaz1<=100 && yaz2>=0 && yaz2<=100 && perf>=0 &&perf<=100 )
            {
                byte ort = Convert.ToByte((yaz1 + yaz2 + perf) / 3);
                if (ort>=50)
                {
                    Console.WriteLine(ort + " ile Geçtiniz");
                }
                else
                {
                    Console.WriteLine(ort + " ile kaldınız");
                }//else
            }//ilk if
            else
            {
                Console.WriteLine("not değerleri 0 ile 100 arasında olmalı");
            }*/

            // Bir ünide öğrencinin vize ve final notu verilecek. Vize %40, final %60 alınacak ve ortalama hesaplanacak. Ortalama 0 ile 49 arası kötü, 50 85 arası iyi, 85 ve üstü ise mükemmel mesajı verecek. //
            Console.WriteLine("Vize Giriniz");
            byte vize_notu = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Final Giriniz");
            byte final_notu = Convert.ToByte(Console.ReadLine());
            if (vize_notu>=0 && vize_notu<=100 && final_notu>=0 && final_notu<=100)
            {
                double ort = vize_notu * 0.4 + final_notu * 0.6;
                if (ort>=0 && ort <= 49)
                {
                    Console.WriteLine(ort + " kötü");
                }
                else if (ort>=50 && ort<=84) Console.WriteLine(ort + " iyi");
                else  Console.WriteLine(ort + " mükemmel");


            }//ilk if
            else Console.WriteLine("vize final değerleri 0 ile 100 arasında olmalı");

            Console.ReadKey();
        }//main
    }//class
}
