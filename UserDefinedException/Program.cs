using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    class Program
    { 

        static void Main(string[] args)
        {
        Temperature temp = new Temperature();
        try
        {
            temp.ShowTemp();
        }
        catch (TempIsZeroException e)
        {
            Console.WriteLine("TempIsZeroException: {0}", e.Message);
        }
        Console.ReadKey();
    }
    }
}
