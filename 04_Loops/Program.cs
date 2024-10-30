using System;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü 

            // Döngüler 1+2+3+4+5+6
            // 3+3=6+4=10+5=15+6=21

            //for(x;y;z)
            //x:başlangıç 
            //y:bitiş
            //z:artış-azalış

            //int i;

            //for (i=0; i<=10; i++) 
            //{
            //    Console.WriteLine("Bıktım");
            //}

            //Console.Read();


            //--------------------------------

            //int i;

            //for (i=1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Read();


            //---------------------------------

            //int i;
            //for (i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Read();

            //-----------------------


            Console.Write("Ekrana yazdırılması istediğiniz değeri giriniz= ");
            int finishValue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= finishValue; i++)
            {
                Console.WriteLine("I love you");

            }

            Console.Read();












            #endregion




        }
    }
}