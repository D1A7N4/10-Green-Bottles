using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_Green_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of green bottles standing on your wall.");
            int j;
            while (int.TryParse(Console.ReadLine(), out j) == false)
            {
                Console.WriteLine("Please enter a valid integer number of bottles to be stood on your wall.");
            }
            for (int i = j; i > 1; i--)
            {
                Console.WriteLine("There were " + i + " green bottles standing on the wall" + Environment.NewLine + i + " green bottles standing on the wall" + Environment.NewLine + "And if one green bottle should accidently fall" + Environment.NewLine + "There'd be " + (i - 1) + " green bottles standing on the wall" + Environment.NewLine);
            }
            Console.WriteLine("There was 1 green bottle standing on the wall" + Environment.NewLine + "1 green bottle standing on the wall" + Environment.NewLine + "And if one green bottle should accidently fall" + Environment.NewLine + "There'd be no green bottles standing on the wall" + Environment.NewLine);
            Console.ReadLine();
        }
    }
}