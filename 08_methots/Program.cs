using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            // Geriye değer döndürmeyen metotlar
            // Customer--> Listele, ekle,sil, güncelle
            // Tekrar edecek kod bloklarında tasarruf sağlar


            //void CustomerList() 
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Veli");

            //}

            //CustomerList();


            //void sum() 
            //{
            //    int x=1;
            //    int y=2;  
            //    int z=x+y;
            //}

            //sum();

            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethots(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethots("Ali Yıldız");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri Adı: "+ name+" "+surname);
            //}

            //CustomerCard("ali", "yıldız");
            //CustomerCard("ayşe", "kaya");
            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    Console.WriteLine("Sayıların toplamı: " + (number1 + number2 + number3));
            //}
            //Sum(1,2,3);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Ali ";
            //    string surname = "Kaya ";

            //    return "Öğrenci Adı Soyadı: "+ name+" "+surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "\nBaşkent: " + capital + "\nBayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //Console.Write("Ülke adını girniz: ");
            //string x = Console.ReadLine();
            //Console.Write("Ülkenin Başkentini giriniz: ");
            //string y = Console.ReadLine();
            //Console.Write("Ülkenin Bayrak renklerini giriniz: ");
            //string z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara","Kırmızı"));

            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1 + number2;

            //    return result;
            //}

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(1, 3));
            //Console.WriteLine(Sum(1, 4));


            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student,int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50) 
            //    {
            //        return "Öğrenci başarılı oldu.";
            //    }else if (result >= 50)
            //    {
            //        return "Öğrenci başarısız oldu.";

            //    }
            //    return "Hatalı işlem";
            //}

            //Console.Write("Öğrenci adı soyadı: ");
            //string name= Console.ReadLine();
            //Console.Write("1. Sınav Notu.");
            //int x1= int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notu.");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notu.");
            //int x3 = int.Parse(Console.ReadLine());

            //Console.Write(ExamResult(name, x1, x2, x3));
            #endregion
            Console.ReadKey();
        }
    }
}
