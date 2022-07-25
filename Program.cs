using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch Case
            Console.WriteLine("Please, introduce a number: ");
            int week_day = Convert.ToInt32(Console.ReadLine());

            switch (week_day)
            {
                case 1:
                    Console.WriteLine("The number matches with Monday");
                    break;
                case 2:
                    Console.WriteLine("The number matches with Tuesday");
                    break;
                case 3:
                    Console.WriteLine("The number matches with Wednesday");
                    break;
                case 4:
                    Console.WriteLine("The number matches with Thursday");
                    break;
                default:
                    Console.WriteLine("The number doesn't match with any option.");
                    break;
            }
        }
    }
}