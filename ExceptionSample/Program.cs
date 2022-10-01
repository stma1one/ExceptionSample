using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace ExceptionSample
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 0;

            Console.WriteLine(a/b);
                                 
            
            Console.ReadKey();
        }
    }
}
