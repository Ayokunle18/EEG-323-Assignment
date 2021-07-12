/**
NAME: AJALA AYOKUNLE MORALAYO
MATRIC NUMBER: EES/18/19/0095
DEPARTMENT: ELECTRICAL/ ELECTRONICS ENGINEERING
COURSE: EEG 323
**/
using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /** this is a program for solving a simultanous equation using cramers rule
            the form of the equation looks like :
            ax + by = e
            cx + dy = f 
            **/
            Console.WriteLine("To solve the equation, input your values");
            Console.Write("a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d: ");
            double d = Convert.ToInt32(Console.ReadLine());
            Console.Write("e: ");
            double e = Convert.ToInt32(Console.ReadLine());
            Console.Write("f: ");
            double f = Convert.ToInt32(Console.ReadLine());
            double x = ((e * d) - (b * f)) / ((a * d) - (b * c));
            double y = ((a * f) - (e * c)) / ((a * d) - (b * c));
            if ((a * d) - (b * c) == 0)
            {
                Console.WriteLine("The equation has no solution");
            }
            else
            {
                Console.WriteLine($"x is equal to {x}");
                Console.WriteLine($"y is equal to {y}");
            }


        }
    }
}
