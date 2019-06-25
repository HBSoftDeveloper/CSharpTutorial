using System;

namespace _02_Console_ReadLineAndReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             
             Console.ReadLine() Metodu klavyeden değer okumak için kullanılan metoddur.
             
             
             */

            Console.Write("Adınızı Giriniz: ");
            string Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Soyadınızı Giriniz: ");
            string LastName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Adınız ve Soyadınız: "+Name+" "+LastName);


            Console.WriteLine();


            Console.Write("Doğum tarihini giriniz: ");
            string BT = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Doğum yeriniz: ");
            string DY = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("DY ve BT: " + DY + " " + BT);




        }
    }
}
