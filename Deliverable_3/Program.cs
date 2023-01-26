// Name: Maxwell Ahmadi
// Date: 01/26/2023
// Project: Deliverable 3
// Description: Deliverable #3 C# Looping Project


using System;
namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            string series = "";

            try
            {
                while (true)
                {
                    Console.Write("Enter a positive integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid, positive integer between 1 and 100!");
                    }
                }

                while (true)
                {
                    Console.Write("Specify the series type: Even or Odd: ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "Odd")
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid series type of either Even or Odd!");
                    }
                }
               
                if (series == "Odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "Even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }

                }
            }

            catch
            {
                Console.WriteLine("Please enter a positive integer number into the field!");
            }
        }
    }
}