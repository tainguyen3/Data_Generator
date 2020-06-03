using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_CheckDigit
{
    public class Random_Characters
    {
        /* Input length of return random number */
        public int Random_Number(double in_length)
        {           
            double max = Math.Pow(10, in_length);
            Random num = new Random();
            return num.Next(0, (int)max -1);
        }
    }
}
