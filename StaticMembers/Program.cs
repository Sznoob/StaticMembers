using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = 0;
            string line = Console.ReadLine();

            bool result = Double.TryParse(line, out number);
            if (result)
            {
                Console.WriteLine("Success: " + number);
            }
            else
            {
                Console.WriteLine("NaN!");
            }
            
            //Math.Round saadaan arvo pyöristymään

            
            
        }
    }
}
