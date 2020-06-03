using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Random_CheckDigit
{
    public class Code128_C 
    {
        public int CheckDigit(string data)
        {
            int result    = -1;  // Skip if length of data is odd
            int check_sum = 105; // Start CodeC = 105
            string[] str = new string[data.Length];
            int tmp = 1;
            if ((data.Length) % 2 == 0)
            {
                for (int i = 0; i < data.Length ; i += 2)
                {
                    str[i] = data.Substring(i,2);
                    check_sum += (int.Parse(str[i]) * tmp);
                    tmp++;
                }
                result = check_sum % 103;
            }
            return result;
        }
        public string Value(string[] character)
        {
            int tmp = 0;
            string[] result = { };
            //string[] result = { "00","01","02","03","04","05","06","07","08","09",
            //                    "10","11","12","13","14","15","16","17","18","19",
            //                    "20","21","22","23","24","25","26","27","28","29",
            //                    "30","31","32","33","34","35","36","37","38","39",
            //                    "40","41","42","43","44","45","46","47","48","49",
            //                    "50","51","52","53","54","55","56","57","58","59",
            //                    "60","61","62","63","64","65","66","67","68","69",
            //                    "70","71","72","73","74","75","76","77","78","79",
            //                    "80","81","82","83","84","85","86","87","88","89",
            //                    "90","91","92","93","94","95","96","97","98","99",
            //                    "CODE B","CODE A","FNC" };
            return result[tmp];
        }

        
            
    }
    
}
