using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealWeightCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeightCalculator weightCalculater = new WeightCalculator
            {
                Height = 159,
                Gender ='w'
            };
            double weight = weightCalculater.GetIdealWeight();
            Console.WriteLine($"the ideal weight is: {weight}");

            if(weight == 54.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("test succeded");
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("test failed");
            }
            Console.ReadKey();
            
        }
    }
}
