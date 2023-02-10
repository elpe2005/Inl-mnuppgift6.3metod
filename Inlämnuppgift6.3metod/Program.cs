using System;

namespace inluppg63metod
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stängav = true;

            while (stängav)
            {
                Console.WriteLine("1. Addera tre tal\n2. Största talet av två\n3. Avsluta programmet");
                int val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        Console.WriteLine(Tal(5, 2, 7));
                        break;
                    case 2:
                        Console.WriteLine(Störst(2, 5));
                        break;
                    case 3:
                        stängav = false;
                        break;
                }
            }
        }
            static int Tal(int tal1, int tal2, int tal3)
            {
                return tal1 + tal2 + tal3;
            }
            static int Störst(int tal1, int tal2)
            {
                if (tal1 > tal2)
                {
                    return tal1;
                }
                {
                    return tal2;
                }
            }
    }
}