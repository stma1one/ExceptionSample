using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
   public class Temperature
    {
        private int temperature;

        public void SetTemp(int t)
        {
            temperature = t;
        }

       /// <summary>
       /// Prints the Temperture
       /// </summary>
       /// <exception cref="TempIsZeroException">throws exception if temperture is 0</exception>
        public void ShowTemp()
        {

            if (temperature == 0)
            {
                throw new TempIsZeroException("Zero Temperature found");
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}
