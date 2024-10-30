using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _03_Making_Desicion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else 

            //örnek1 şifre gir eğer.. ise doğru değilse yanlış 

            //           Console.Write("Lütfen Şifreyi Giriniz: ");

            //           string password; 
            //           password = Console.ReadLine();

            //           if (password == "abcd")

            //           {
            //               #region ıf else 


            //               Console.WriteLine("Şifre Doğru!");

            //}
            //           else
            //           {

            //               Console.WriteLine("Şifre Yanlış");

            //           }

            //           Console.Read();
            //---------------------------------------------
            //örnek2 şehir gir eğer... ise doğru değilse yanlış  

            //string capital, country;
            //Console.Write("Başkent Giriniz: ");
            //capital= Console.ReadLine();

            //Console.Write("Ülke Giriniz: ");
            //country = Console.ReadLine();


            //if  (capital == "Ankara" & country == "Türkiye")
            //{ 
            //    Console.Write("Veriler doğru");
            //}
            //else
            //{
            //    Console.Write("Hatalı Veri");
            //}

            //Console.Read();
            //------------------------------------------
            //örnek3 

            //int number;
            //Console.Write("Sayı Giriniz= ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 1)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}
            //Console.Read();
            //------------------------------------------

            //örnek4 sınav notu gir ortalamasını al çıkan ortalamayı ve ort. göre not durumunu ekrana yazdır. 
            //int exam1, exam2, exam3, average;
            //string result = "Böyle Bir Sonuç Olamaz!";

            //Console.Write("Sınav1= ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2= ");
            //exam2 = int.Parse(Console.ReadLine  ());

            //Console.Write("Sınav3= ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınav Ortalaması=" + average);

            //Console.WriteLine();

            //if (average >= 0 & average <= 50)
            //{
            //    result = "Sonuç Düşük!"; 
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average >= 85 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}


            //Console.WriteLine(result);


            //Console.Read();
            //-----------------------------------------------------------


            //string city;
            //Console.Write("Bir şehir giriniz= ");
            //city = Console .ReadLine();

            //if (city== "ordu" | city== "trabzon" | city== "sivas" )
            //{
            //    Console.WriteLine("Şehir Mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Read();

            //--------------------------------------------

            //Console.Write("Bir kullanıcı adı giriniz= ");
            //string name= Console.ReadLine();

            //if (name =="admin")
            //{
            //    Console.Write ("Hoşgeldiniz!");
            //}

            //else
            //{
            //    Console.Write("Bu kullanıcı kabul edilemez");
            //}

            //Console.Read();

            //--------------------------------
            #endregion


            #region Mod İşlemleri 

            //örnek 
            //int number;
            //number = 33;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Read();
            //-----------------------------


            //Console.Write("Lütfen 1. sayıyı giriniz= ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz= ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan= " + result);
            //Console.Read();

            //----------------------------

            //Console.Write("Lütfen bir sayı giriniz :)) = ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}

            //Console.Read();

            //----------------------------




            #endregion


            #region Char değişkenler ile karar yapıları

            //  char team;
            //  Console.Write("Lütfen takım sembolünü giriniz= ");
            //  team = char.Parse(Console.ReadLine());

            //  if (team == 'g' | team == 'G')
            //  {
            //      Console.WriteLine("Galatasaray");
            //  }            

            //  if (team =='f'| team=='F')
            //  {
            //      Console.WriteLine("Fenerbahçe");
            //  }

            //  if (team =='t'| team=='T')
            //  {
            //      Console.WriteLine("Trabzonspor");
            //  }

            //  if (team =='b'| team=='B')
            //  {
            //      Console.WriteLine("Beşiktaş");
            //  }



            //  Console.Read();

            //-------------------------------


























            #endregion

            #region Örnek Proje Uygulaması 

            //Console.WriteLine("*****Restoran Menüsü*****");
            //Console.WriteLine("------------------------------------------");

            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine();


            //string menuItem;


            //Console.Write("detayını görmek istediğiniz mwnuyu seçiniz=");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("Mantı");
            //    Console.WriteLine("Sarma");
            //    Console.WriteLine("Köfte");

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("Domates Çorbası ");
            //    Console.WriteLine("Mercimek Çorbası");
            //    Console.WriteLine("Yoğurt Çorbası");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("Sucuklu pizza");
            //    Console.WriteLine("Meyveli Pizza");
            //    Console.WriteLine("Vegan Pizza");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("Kola");
            //    Console.WriteLine("Ayran");
            //    Console.WriteLine("Soda");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("Trilice");
            //    Console.WriteLine("Soğuk Baklava");
            //    Console.WriteLine("Kazandibi");

            //}


            //Console.Read();

            #endregion

            #region Switch Case 


            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
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
            //    default: Console.Write("Lütfen 1-12 arasında bir sayı giriniz."); break; 

            //}

            //Console.Read();



            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("birinci sayı gir: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("ikinci sayıyı gir: ");
            //number2= int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğin işlemi gir= ");
            //symbol= char.Parse(Console.ReadLine()); 

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2; 
            //        Console.WriteLine("Toplam= " + result); break; 

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark= " + result); break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım= " + result); break;
                    

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm= ");  break;  
            //}


            //Console.Read();



            #endregion



















        }
    }
}
