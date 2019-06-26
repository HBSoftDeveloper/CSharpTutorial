using System;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            for (int i = 1; i <= 1000; i++)
            {
                if (i%17== 0)
                {
                    Console.Write(i+" * ");
                }
            }

            Console.WriteLine();

            int z;

            for (z=5; z< 10; z++)
            {
                Console.Write(z);
            }

            Console.WriteLine();

            for (int i = 0; i < 100; )
            {
                Console.Write(i);
                i = i + 20;
            }

            Console.WriteLine();

            int y = 0;

            for (; y < 100; y++)
            {
                Console.Write(y);
            }

            Console.WriteLine();

            int u = 30;

            for (; ;)
            {
                u++;

                Console.WriteLine(u);

                if (u<20)
                {
                    Console.Write("MB");
                }

                else
                {
                    break;
                }
            }

            #endregion

            #region While Döngüsü

            int a = 0;
            int b = 0;

            bool durum = true;

            string ad = "Murat";

            while (a<10)
            {
                Console.WriteLine(a);

                a = a + 2;
            }

            Console.WriteLine();

            while (ad == "Murat")
            {
                b++;

                if (b>5)
                {
                    ad = "Hüseyin";
                }

                Console.WriteLine(ad);

            }

            while (durum)
            {
                b++;

                if (b>10)
                {
                    durum = false;
                }

                Console.WriteLine(durum);
                Console.WriteLine(ad);
            }

            Console.WriteLine("Başladı");

            int t = 15;

            while (t<15)
            {
                t++;
                Console.WriteLine(t);
            }

            Console.WriteLine("Bitti");

            #endregion

            #region Do While

            int m = 15;

            do
            {
                m++;

                Console.WriteLine(m);

            } while (m<15);

            #endregion
        }

    }
}
