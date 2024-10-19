using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //    Console.WriteLine("Toplam: " + total);
            //}

            //List<int> numbers = new List<int> 
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Hello World";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Öğrenci sayısını al
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentsNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismi: ");
                studentsNames[i] = Console.ReadLine();

                double totalExamResult = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsNames[i]} isimli öğrencinin {j + 1}. sınav notu: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//Notları topluyoruz

                }
                studentExamAvg[i] = totalExamResult / 3;
                
                Console.WriteLine("------------------------------");
            }

            //Öğrencilerin sınav ortalama
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentsNames[i]} isimli öğrencinin not ortalaması: {studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine("Öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine("Öğrenci dersi geçemedi.");
                }

                Console.WriteLine("------------------------------");
            }

            #endregion
            Console.Read();
        }
    }
}
