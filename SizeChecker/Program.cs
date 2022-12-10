using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeChecker
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Input X size(number):");
            int x = int.Parse(Console.ReadLine());

            if (InputChecker(x) == 0)
            {
                return 0;
            }

            Console.WriteLine("Input Y size(number):");
            int y = int.Parse(Console.ReadLine());

            if (InputChecker(y) == 0)
            {
                return 0;
            }

            Console.WriteLine("Input Z size(number):");
            int z = int.Parse(Console.ReadLine());

            if (InputChecker(z) == 0)
            {
                return 0;
            }

            Console.WriteLine("Input hole A size(number):");
            int a = int.Parse(Console.ReadLine());

            if (InputChecker(a) == 0)
            {
                return 0;
            }

            Console.WriteLine("Input hole B size(number):");
            int b = int.Parse(Console.ReadLine());

            if (InputChecker(b) == 0)
            {
                return 0;
            }

            SizeCheck(x, y, z, a, b);

            return 1;
        }

        static int InputChecker(int input)
        {
            if (input <= 0)
            {
                Console.WriteLine("Input size can't be less or equal zero!");
                return 0;
            }

            else
            {
                return 1;
            }
        }

        static void SizeCheck(int x, int y, int z, int a, int b)
        {
            if ((x == a && y == b) || (x == b && y == a))
            {
                Console.WriteLine("The beam will pass through the hole!");
            }

            else if ((z == a && y == b) || (x == a && z == b))
            {
                Console.WriteLine("The beam will pass through the hole!");
            }

            else
            {
                Console.WriteLine("The beam won't pass through the hole!");
            }
        }
    }
}
