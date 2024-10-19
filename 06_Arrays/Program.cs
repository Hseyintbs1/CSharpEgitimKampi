using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örenkleri
            //aynı tipte çok sayıda veriyi tutmak için kullanılır.
            // 2,4,6,8,10
            //sarı, mavi, yeşil, kırmızı
            //ankara,konya,istanbul,izmir

            //syntax= Değişken tipi[] diziAdı = new Değişken tipi[eleman sayısı];

            //string[] colors = new string[4];

            //colors[0] = "Sarı";
            //colors[1] = "Mavi";
            //colors[2] = "Yeşil";
            //colors[3] = "Kırmızı";

            //Console.WriteLine(colors[2]);

            //string[] cities = { "Ankara", "Konya", "İstanbul", "İzmir" };

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[7] = 748;


            //Console.WriteLine(numbers[7]);
            //Console.WriteLine(numbers[5]);

            //String[] strings = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(strings[2]);
            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Mavi", "Yeşil", "Kırmızı", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 54, 67, 78, 39, 23, 45, 26, 643, };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);

            //    }
            //}

            //char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            //for (int i = 0; i < characters.Length; i++)
            //{
            //    Console.WriteLine(characters[i]);
            //}

            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 95, 145, 100, 10 , 2555};

            //int maxNumber = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("En büyük sayı: " + maxNumber);

            //string[] persons = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Ahmet", "Zeynep", "Merve", "Kemal", "Kerem" };
            //Console.WriteLine("Dizi eleman sayısı: " + persons.Length);

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 54, 67, 78, 39, 23, 45, 26, 643, };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 54, 67, 78, 39, 23, 45, 26, 643, };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotları
            //string[] customers= { "ali", "veli", "ayşe", "fatma", "mehmet", "ahmet", "zeynep", "merve", "kemal", "kerem" }; 
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine("Index: " + index);

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 54, 67, 78, 39, 23, 45, 26, 643, };
            //Console.WriteLine("Eleman En büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());



            #endregion

            #region Kullanıcıdan değer alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"{i + 1}. Şehirin adını giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.Write("Girilen şehirler: ");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write(cities[i] + ", ");
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("----------");
            //Console.WriteLine("Tek sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            Console.Read();
        }
    }
}
