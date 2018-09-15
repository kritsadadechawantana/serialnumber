using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class SerialCalculator
    {
        public long[] Calculate(long number)
        {
            var range = 2;
            while (true)
            {
                var serialNumber = new List<long>();
                var baseNumber = number / range;
                long start = (range % 2) == 0 ? baseNumber - ((range / 2) - 1) : baseNumber - (range / 2);
                if(start <= 0)
                {
                    serialNumber.Add(number);
                    return serialNumber.ToArray();
                }
                
                for (long i = start; i < (start + range); i++)
                {
                    serialNumber.Add(i);
                }
                var result = serialNumber.Sum(it => it);
                if (result == number) return serialNumber.ToArray();
                range++;
            }
        }
    }
}
