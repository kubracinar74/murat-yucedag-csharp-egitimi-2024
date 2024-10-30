using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Değişkenler  
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 0533 716 99 62";
            //customerEmail = "deneme@gmail.com";
            //district = "kadıköy";
            //city = "istanbul";

            //Console.WriteLine("***Rezervasyon Kartı");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim" + customerPhone);
            //Console.WriteLine("Email Adresi"+ customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 0536 556 45 48";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim" + customerPhone);
            //Console.WriteLine("Email Adresi" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);


            //Console.Read();
            #endregion

            #region int değişkenler 


            //int number = 5;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 10;
            int waterPrice = 50;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***Restoran Menu Fiyatı***");
            Console.WriteLine();
            Console.WriteLine("---Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("---Kola:" + cokePrice + "TL");
            Console.WriteLine("---Su:" + waterPrice + "TL");
            Console.WriteLine("---Kızartma:" + friesPrice + "TL");
            Console.WriteLine("---Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("---Limonata:" + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***Restoran Menu fiyatı");
            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 5;
            int friesCount = 5;
            int pizzaCount = 2;
            int lemonadeCount = 4;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;


            totalCokePrice = cokeCount * cokePrice;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;


            Console.WriteLine("Hamburger tutarı:" + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma  Tutarı:" + totalFriesPrice + "TL");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");




            Console.Read();




            #endregion



            Console.WriteLine("Ekrana yazılmasını istediğiniz değeri giriniz");
            int finishValue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= finishValue; i++) ;
            {
                Console.Write("Yaşasın Cumhuriyet");
            }




        }
    }
}