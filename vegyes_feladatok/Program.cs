using System;

namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1() 
        {
            Console.WriteLine("Mennyien értékelték a programot");
            int ertekelesek = int.Parse(Console.ReadLine());
            Console.WriteLine("Mennyien értékelték pozitívan?");
            int db = int.Parse(Console.ReadLine());
            int ertek = 0;

            ertek = db%ertekelesek;
            //Console.WriteLine(ertek);

            if (ertek >= 90)
            {
                Console.WriteLine("A játék értékelése nagyon pozitív");
            }
            else if (75 <= ertek)
            {
                Console.WriteLine("A játék értékelése pozitív");
            }
            else if (55 <= ertek)
            {
                Console.WriteLine("A játék értékelése többnyire pozitív");
            }
            else if (45 <= ertek)
            {
                Console.WriteLine("A játék értékelése vegyes");
            }
            else if (25 <= ertek)
            {
                Console.WriteLine("A játék értékelése többnyire negatív");
            }
            else if (10 <= ertek)
            {
                Console.WriteLine("A játék értékelése negatív");
            }
            else if(9 > ertek) 
            {
                Console.WriteLine("A játék értékelése nagyon negatív");
            }
        }

        static void feladat2() 
        {
            Console.WriteLine("Fasz kivan");
        }

        static void feladat3() { }

        static void feladat4() { }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            feladat1();
            feladat2();

        }
    }
}
