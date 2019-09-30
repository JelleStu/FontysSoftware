using System;

namespace ChristmasTreeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string keypressed;
            Console.Write("Hoeveel lijnen?");
            string linestring = Console.ReadLine();

            Console.WriteLine("Met welke toets moet het genegereerd worden?");

            keypressed = Console.ReadLine();

            int line = Convert.ToInt16(linestring);*/


            int spaces = 10;
            int asterix = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterix; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                spaces--;
            }
        }
    }
}
