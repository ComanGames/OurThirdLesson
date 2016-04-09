using System;
using static System.Console;

namespace OurThirdLesson
{
    class Program
    {
        static void Main()
        {
            //Method without parameters
            SayHello();

            //Methods with parameters with diffrent modifications
            string text = "Hello";
            int x = 10;
            Say(text, x);

            Say("Yura", 3);
            Say("Hello Sasha", 20);

            ReadKey();
        }

         static void SayHello()
        {
           WriteLine("Helo world"); 
        }

        static void Say(string hello, int count)
        {
            for (int i = 0; i < count; i++)
               WriteLine(hello);
        }

        //return us result
        static int Formula1(int n)
        {

            return (2*n) - 7;

        }

        //not return us result
        private static void Formula2(int n)
        {
            double a = (Math.Pow(-1, n)/(Math.Pow(n, 2)));
            WriteLine($"a{n}=\t{a}");
        }
    }
}
