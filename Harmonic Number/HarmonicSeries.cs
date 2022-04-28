using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic_Number
{
    internal class HarmonicSeries
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter Number which you want Harmonic value");
            int num=Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for(int i=1;i<=num;i++)
            {
                result += (1 / (Convert.ToDouble(i)));
                if (i==num)
                {
                    Console.WriteLine($"1 /{i}= ");
                }
                else
                {
                    Console.WriteLine($"1/{i}+ ");
                }
            }
            Console.WriteLine(result);
        }
    }
}
