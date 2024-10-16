using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Döngüler
            #region For Döngüsü
            //Döngüler 1+2+3+4+5+...
            //3+3=6+4=10+5=15+6=21

            //For(x,y,z)
            //x: Başlangıç değeri
            //y: Bitiş değeri
            //z: Artış miktarı

            //int i;

            //for (i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet.");
            //}

            #endregion

            #region For döngüsü ile karar yapıları

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 5 == 0 )
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine("Toplam Değer: " + totalValue);


            //int totalValue = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("--------------");
            //Console.WriteLine("Toplam Değer: " + totalValue);

            //int count = 0;
            //for (int i = 1; i < 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine("Toplam 7'ye bölünen sayı adedi: " + count);

            //BinaryReader bakteri kendini ikiye bölerek çoğaltıyor kullanıcıdan alınan saat sürecinde oluşan bakteri sayısını bulunuz.

            //Console.Write("Saat süresini giriniz: ");
            //int hour = Convert.ToInt32(Console.ReadLine());
            //int bakteriaCount = 1;

            //for (int i = 0; i < hour; i++)
            //{
            //    bakteriaCount *= 2;
            //}

            //Console.Write(hour + " saat sonunda oluşan bakteri sayısı : " + bakteriaCount);


            #endregion

            #region While Döngüsü

            //while (şart)
            //{
            //    //Koşul sağlandığı sürece çalışacak kodlar
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <=10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while ( i<= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Toplam Değer: " + sum);



            #endregion

            #region Örnek Sınav sorusu
            // klavyeden girilen 3 basamaklı sayının basamakları toplamını bulunuz.

            //Console.Write("3 basamaklı bir sayı giriniz: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int totalValue = 0;

            //while (number > 0)
            //{
            //    totalValue += number % 10;
            //    number /= 10;

            //    Console.WriteLine("Kalan Sayı: " + number);
            //}

            //Console.WriteLine("Basamaklar toplamı: " + totalValue);

            #endregion

            #endregion


            Console.Read();
        }
    }
}
