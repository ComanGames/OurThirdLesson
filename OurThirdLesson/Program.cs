using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OurThirdLesson
{
    class Program
    {
        static void Main()
        {

            WriteLine("Formula 1");
            for (int i = 0; i <=10; i++)
                WriteLine($"a{i}=\t{Formula1(i)}");

            WriteLine("Formula2");
            for (int i = 0; i <= 10; i++)
                Formula2(i);

            ReadKey();


        }

        private static void Formula2(int n)
        {
            double a = (Math.Pow(-1, n)/(Math.Pow(n, 2)));
            WriteLine($"a{n}=\t{a}");
        }

        static int Formula1(int n)
        {

            return (2*n) - 7;

        }

    }
}
