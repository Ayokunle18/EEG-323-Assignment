/**
NAME: AJALA AYOKUNLE MORALAYO
MATRIC NUMBER: EES/18/19/0095
DEPARTMENT: ELECTRICAL/ ELECTRONICS ENGINEERING
COURSE: EEG 323
**/
using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a Full-time or a Part-time student?");
            string student = Console.ReadLine().ToLower();
            if (student == "full-time" || student == "full")
            {
                Console.WriteLine("What is your course of study?");
                string course = Console.ReadLine().ToUpper();
                Console.WriteLine(course + " is a good course");
            }
            else
            {
                if (student == "part-time" || student == "part")
                {
                    Console.WriteLine("How many credit are you taking?");
                    Console.Write("Input the number of credit: ");
                    int credit = Convert.ToInt32(Console.ReadLine());
                    if (credit > 6)
                    {
                        Console.WriteLine("Too much units for a part-time student");
                    }
                    else
                    {
                        Console.WriteLine("Proceed");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }

        }
    }
}
