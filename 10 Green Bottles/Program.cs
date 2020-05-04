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
            for (int i = 10; i >1; i--)
            {
                Console.WriteLine("There were " + i + " green bottles standing on the wall" +Environment.NewLine+ i + " green bottles standing on the wall" + Environment.NewLine + "And if one green bottle should accidently fall" + Environment.NewLine + "There'd be " + (i - 1) + " green bottles standing on the wall" + Environment.NewLine);
            }
            Console.WriteLine("There was 1 green bottle standing on the wall" + Environment.NewLine + "1 green bottle standing on the wall" + Environment.NewLine + "And if one green bottle should accidently fall" + Environment.NewLine + "There'd be no green bottles standing on the wall" + Environment.NewLine);
        }
    }
}
