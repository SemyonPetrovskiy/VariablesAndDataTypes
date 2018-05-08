using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var index = 5; // int
            Console.WriteLine(index);

            var apple = "Apple"; // string
            Console.WriteLine(apple);

            object obj = 2;
            Console.WriteLine(obj);

            object obj2 = "Hello world!";
            Console.WriteLine(obj2);

            char a = 'A';
            Console.WriteLine(a);

            string hello = "Hello";
            Console.WriteLine(hello);

            decimal rate = 5.4M;
            Console.WriteLine(rate);

            double weight = 180.34;
            Console.WriteLine(weight);

            float height = 166.23F;
            Console.WriteLine(height);

            byte b = 3;
            Console.WriteLine(b);

            bool isAlive = true;
            Console.WriteLine(isAlive);

            isAlive = false;
            Console.WriteLine(isAlive);

            int tax = 9;
            Console.WriteLine(tax);

            tax = 5;
            Console.WriteLine(tax);

            tax = 7;
            Console.WriteLine(tax);

            Console.ReadKey();
        }
    }
}
