using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fidget = 3.5;
            double Memes = 5;
            bool choice = false;
            do
            {
                Console.Write("Please enter amount.");
                double amount = int.Parse(Console.ReadLine());

                Console.Write("Please enter measurement type: fidget spinners, memes, inches, or foot.");
                string measure = (Console.ReadLine());

                choice = false;

                if (measure == "fidget spinners")
                {
                    amount /= Fidget;
                    Console.WriteLine(amount + " Inches");

                    Console.WriteLine("Would you like another conversion: y or n?");
                    if (Console.ReadLine() == "y")
                    {
                        choice = true;
                    }
                }
                else if (measure == "memes")
                {
                    amount /= Memes;
                    Console.WriteLine(amount + " Feet");

                    Console.WriteLine("Would you like another conversion: y or n?");
                    if (Console.ReadLine() == "y")
                    {
                        choice = true;
                    }
                }
                else if (measure == "foot")
                {
                    amount *= Memes;
                    Console.WriteLine(amount + " Memes");

                    Console.WriteLine("Would you like another conversion: y or n?");
                    if (Console.ReadLine() == "y")
                    {
                        choice = true;
                    }
                }
                else if (measure == "inches")
                {
                    amount *= Fidget;
                    Console.WriteLine(amount + " fidget spinners");

                    Console.WriteLine("Would you like another conversion: y or n?");
                    if (Console.ReadLine() == "y")
                    {
                        choice = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter enter fidget spinner, memes, inch, or foot for the measurement types");

                    Console.WriteLine("Would you like another conversion: y or n?");
                    if (Console.ReadLine() == "y")
                    {
                        choice = true;
                    }
                }
            } while (choice);

            Console.WriteLine("Have a nice day.");
        }
    }
}
