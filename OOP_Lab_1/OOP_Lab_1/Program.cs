using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            string Case = "Zero";
            Console.Write("X = ");
            double x = Convert.ToInt32(Console.ReadLine());
            double form = 1 / Math.Abs(x + 2) + 1;
            if (x < 1) 
            {
                y = form - 7 * x * x + x - 8;
                Case = "firs";
            }
            if (x >= 1 && x <= 4) 
            {
                y = form - 1 / Math.Tan((x + 4) / Math.Pow(11, 1/2)) + 3;
                Case = "second";
            }
            if (x > 4) 
            {
                y =  form - Math.Pow((1 + Math.Abs(Math.Pow(Math.Cos(x),3))), 1 / 2);
                Case = "third";
            }
            Console.WriteLine($"Y = {y}\nCase: {Case}\n\n");

            Console.WriteLine("Method 2");
            if (x < 1)
            {
                y = form - 7 * x * x + x - 8;
                Case = "firs";
            }
            else {
                if (x >= 1 && x <= 4)
                {
                    y = form - 1 / Math.Tan((x + 4) / Math.Pow(11, 1 / 2)) + 3;
                    Case = "second";
                }
                else {
                    y = form - Math.Pow((1 + Math.Abs(Math.Pow(Math.Cos(x), 3))), 1 / 2);
                    Case = "third";
                }
            }
            Console.WriteLine($"Y = {Math.Round(y, 4)}\nCase: {Case}");


            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double F = 0;
            double x1, a, b, c;
            Console.Write("\nEnter values\nx = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thinary №1");
            if (x1 < 0 && b != 0)
            {
                F = a - x1 / 10 + b;
            }
            if (x > 0 && b == 0)
            {
                F = x1 - a / x - c;
            }
            else
            {
                F = 3 * x1 + 2 / c;
            }
            Console.WriteLine($"F = {Math.Round(F, 4)}");

            Console.WriteLine("Thinary №2");
            if (x1 < 0 && b != 0)
            {
                F = a - x1 / 10 + b;
            }
            else
            {
                if (x1 > 0 && b == 0)
                {
                    F = x1 - a / x1 - c;
                }
                else
                {
                    F = 3 * x1 + 2 / c;
                }
            }
            Console.WriteLine($"F = {Math.Round(F, 4)}");
        }

    }
}