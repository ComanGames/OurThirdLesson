using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurThirdLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "10";
            int a = 10;
            //int to string
            s = a.ToString();
            //string to int
            a = Int32.Parse(s);
            while (true)
            {
                Console.WriteLine("Write your number");

            }

        }
    }
}
