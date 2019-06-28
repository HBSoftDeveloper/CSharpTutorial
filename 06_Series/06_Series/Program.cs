using System;

namespace _06_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Ad = new string[6];

            int[] Not = new int[6];

            string[] Soyadi = new string[] { "Bilginer", "Çalışkan", "Öreke" };
            string[] Soyadi2= new string[3] { "Bilginer", "Çalışkan", "Öreke"};

            string[] Adlar = { "Murat", "Bilginer" };

            Adlar[0] = "Ferhat";
            Adlar[1] = "Hüseyin";

            Console.WriteLine(Adlar[0].ToString());
            Console.WriteLine(Adlar[1].ToString());
            
        }
    }
}
