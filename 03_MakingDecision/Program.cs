using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Karar Yapıları

            #region If Else

            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış.");
            //}

            //string capital, country;

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" && country == "Türkiye")
            //{
            //    Console.WriteLine("Başkent ve Ülke doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Başkent ve Ülke yanlış.");
            //}

            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, avg;
            //string result;

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avg = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalamanız: " + avg);

            //if (avg > 0 & avg <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //else if (avg > 50 & avg <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //else if (avg > 70 & avg <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //else if (avg > 85 & avg <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //else
            //{
            //    result = "Hatalı giriş yaptınız.";
            //    Console.WriteLine("Hatalı giriş yaptınız.");
            //}

            //Console.WriteLine("Sonuç: " + result);

            //string city;
            //Console.Write("Şehir adını giriniz: ");
            //city = Console.ReadLine();
            //if (city == "Ankara" | city == "Adana"| city == "Bursa"| city == "Trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı Doğru.");
            //}

            #endregion


            #region mod alma
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1. sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());

            //int result1 = number1 % number2;
            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan: " + result1);

            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0) 
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}


            #endregion

            #region Char Değişkenler ile karar yapıları

            // char team;
            //Console.Write("Lütfen takım Sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız.");
            //}

            #endregion

            #region Örnek proje uygulaması

            //Console.WriteLine("****** CSharp Restourant ******");
            //Console.WriteLine();
            //Console.WriteLine("-------Menü-------");
            //Console.WriteLine();
            //Console.WriteLine("1. Ana Yemekler");
            //Console.WriteLine("2. Çorbalar");
            //Console.WriteLine("3. Pizzalar");
            //Console.WriteLine("4. İçecekler");
            //Console.WriteLine("5. Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("------------------");
            //Console.WriteLine();
            //Console.Write("Detayını Görmek istediğiniz menü seçimi: ");
            //string menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---Ana Yemekler---");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma tabağı");
            //    Console.WriteLine("3-Fırında somon");
            //    Console.WriteLine("4-Patlıcan musakka");
            //    Console.WriteLine("5-Fasulye pilav");
            //    Console.WriteLine();
            //    Console.WriteLine("---Ana Yemekler---");

            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine();
            //    Console.WriteLine("----Çorbalar-----");

            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Pizzalar----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("----Pizzalar----");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----İçecekler----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //}
            //else if (menuItem == "5") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Tatlılar----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //}


            #endregion

            #region Switch Case

            //int MonthNumber;

            //Console.Write("Lütfen bir ay numarası giriniz: ");
            //MonthNumber = int.Parse(Console.ReadLine());

            //switch (MonthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı giriş yaptınız."); break;
            //}


            #endregion

            #region Switch case hesap makinesi

            //int number1, number2, result;

            //char symbol;

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen işlem sembolünü giriniz: ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //    case '%':
            //    result = number1 % number2;
            //    Console.WriteLine("Mod: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız.");
            //        break;
            //}

            #endregion

            #endregion

            Console.ReadLine();


        }
    }
}