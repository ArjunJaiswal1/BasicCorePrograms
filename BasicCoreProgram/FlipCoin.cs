using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Basicprograms
    {
        public void FlipCoin()
        {
            Console.WriteLine("Enter the number of times to Flip Coin");
            double num = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            double headCount = 0, tailCount = 0;
            for (int i = 0; i < num; i++)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
            }
            headCount *= (100 / num);
            tailCount *= (100 / num);
            Console.WriteLine("The Percentage of Heads vs Tails is {0}% and {1}%", headCount, tailCount);
            Console.ReadKey();
        }
    }
}

