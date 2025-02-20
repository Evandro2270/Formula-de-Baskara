﻿using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
         
                double a = 1.0, b = -3.0, c = -4.0;

                // double delta = b * b - 4.0 * a * c;

                double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

                double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine(delta);
                Console.WriteLine(x1);
                Console.WriteLine(x2);

            }
        }
    }
}