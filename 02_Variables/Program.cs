using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişkenler
            #region Double Değişkenler
            //double number ;
            //number = 5.5;
            //Console.WriteLine(number);

            //Console.WriteLine("****** Fiyat Listesi ******");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı    : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı   : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potato + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomato + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;  

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            //Console.WriteLine("***** Fiş *****");
            //Console.WriteLine();
            //Console.WriteLine("ÜRÜN    | AĞIRLIK (KG) | BİRİM FİYAT | TOPLAM FİYAT|");
            //Console.WriteLine("Elma    : " + appleGram + "  kg    x " + applePrice + " TL    = " + (appleTotalPrice = appleGram * applePrice) + "    TL");
            //Console.WriteLine("Portakal: " + orangeGram + "   kg    x " + orangePrice + " TL    = " + (orangeTotalPrice = orangeGram * orangePrice) + "     TL");
            //Console.WriteLine("Çilek   : " + strawberryGram + "   kg    x " + strawberryPrice + "    TL    = " + (strawberryTotalPrice = strawberryGram * strawberryPrice) + "       TL");
            //Console.WriteLine("Patates : " + potatoGram + "  kg    x " + potato + "  TL    = " + (potatoTotalPrice = potatoGram * potato) + "    TL");
            //Console.WriteLine("Domates : " + tomatoGram + "  kg    x " + tomato + "  TL    = " + (tomatoTotalPrice = tomatoGram * tomato) + "     TL");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + (appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice) + " TL");
            //Console.WriteLine();


            #endregion

            #region Char Değişkenler

            //char sembol = 'A';
            //Console.WriteLine(sembol);



            #endregion

            #region Klavyeden Veri Girişi

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerEmail, passengerdistrict, passengercity,passengerIdentityNumber ;

            //Console.Write("Adınız: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Soyadınız: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Email Adresiniz: ");
            //passengerEmail = Console.ReadLine();
            //Console.Write("İlçeniz: ");
            //passengerdistrict = Console.ReadLine();
            //Console.Write("Şehriniz: ");
            //passengercity = Console.ReadLine();
            //Console.Write("TC Kimlik Numaranız: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("***** Yolcu Bilgileri *****");
            //Console.WriteLine();
            //Console.WriteLine("Adı Soyadı: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " + passengerdistrict + "/" + passengercity);
            //Console.WriteLine("TC Kimlik Numarası: " + passengerIdentityNumber);
            //Console.WriteLine();


            #endregion

            #region Klavyeden tam sayı girişleri ve dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;


            //Console.WriteLine("***** Alışveriş Sepeti *****");
            //Console.WriteLine();
            //Console.Write("Ayakkabı Adedi: ");
            //shoeCount = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Bilgisayar Adedi: ");
            //computerCount = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sandalye Adedi: ");
            //chairCount = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Televizyon Adedi: ");
            //tvCount = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //Console.WriteLine("Ayakkabı Birim Fiyatı: " + shoePrice + " TL");
            //Console.WriteLine("Bilgisayar Birim Fiyatı: " + computerPrice + " TL");
            //Console.WriteLine("Sandalye Birim Fiyatı: " + chairPrice + " TL");
            //Console.WriteLine("Televizyon Birim Fiyatı: " + tvPrice + " TL");
            //Console.WriteLine();
            //int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);
            //Console.WriteLine("Toplam Tutar = " + totalPrice + " TL");
            //Console.WriteLine("***********************");



            #endregion

            #region klavyeden ondalıklı sayı girişleri

            //double exam1, exam2, exam3, average;
            //Console.Write("Lütfen birinci sınav notunuzu giriniz:");
            //exam1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen ikinci sınav notunuzu giriniz:");
            //exam2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen üçüncü sınav notunuzu giriniz:");
            //exam3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen dördüncü sınav notunuzu giriniz:");


            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalamanız: " + average);

            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;
            //Console.Write("Cinsiyetinizi giriniz (E/K):");
            //gender = char.Parse(Console.ReadLine());

            //if (gender == 'E' || gender == 'e')
            //{
            //    Console.WriteLine("Cinsiyetiniz = Erkek");
            //}
            //else if (gender == 'K' || gender == 'k')
            //{
            //    Console.WriteLine("Cinsiyetiniz = Kadın");
            //}
            //else 
            //{
            //Console.WriteLine("Hatalı giriş yaptınız.");
            //}

            #endregion


            #endregion
            Console.ReadLine();
        }
    }
}
