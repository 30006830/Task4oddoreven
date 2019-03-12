using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time for a game!");
            Console.WriteLine("Type a number and I'll tell you if it is odd or even.");
            Console.WriteLine("Enter a number now: ");

            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
                Console.WriteLine("The number you typed in is Even.");
            else
                Console.WriteLine("The number you typed in is Odd.");

            Console.ReadLine();
            Console.Clear();

        }
    }
}
