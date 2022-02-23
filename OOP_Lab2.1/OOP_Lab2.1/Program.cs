using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = 0;
            for (int i = 1; i <= 15; i++) 
            {
                P += ((Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1 / i), 2)))/(i*i);  
            }
            Console.WriteLine($"P = {Math.Round(P, 4)}");

            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i1 = N;
            double P1 = 0;
            while (i1 < 16)
            {
                P1 += i1 * N / i1 * i1 + N * N;
                i1++;
            }
            Console.WriteLine($"P1 = {Math.Round(P1, 4)}");
        }
    }
}
