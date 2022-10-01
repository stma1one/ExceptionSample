using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
namespace ExceptionSample3
{
   
    class Program
    {
        static void Main(string[] args)
        {
            #region nothing to see here move along
            CultureInfo oldCI = Thread.CurrentThread.CurrentCulture;
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
 Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            #endregion


            //WHEN CAUGHT BY THE INNER FUNCTION
            try
            {
                
                Person p = new Person("Tal");
                Console.WriteLine($@"when caught by inner function
                        the caller is not aware of any problem...
                        so you must check if the person was created
                        successfully.
                        for this example p.t== null--->{p.GetTemperture()==null}");
              
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "never be Printed:((((");
            }
            //COUGHT BY MAIN
            try
            {
                Person p1 = new Person("Tal", 29);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message[1] + " Tried to put 29 celsius as temperture- Caught it at MAIN Func\n\n\n\n\n\n\n\n");
            }
            //THROW...
            try
            {
                Person p2 = new Person("Talsi", 36.7);

            }
            catch (FormatException e)
            {
                Console.WriteLine("this is format problem\n\n\n\n\n\n\n\n\n");
            }
            // CATCH hIRARCHY
            try
            {
                Person p3 = new Person(31);
            }

          

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"This is the Person Exception:{e.Message}\n  This is the exception from Temperture {e.InnerException.Message}\n\n\n\n\n\n\n\n\n\n");
            }
            

           


            try
            {
                Person p2 = new Person("Tal", 30.7);
                //Person p2=new Person("Talsi",36.8);
               // Person p2=new Person(null,36.8);
                Console.WriteLine(p2.GetName()[1]);

            }

            catch (FormatException e)
            {
                Console.WriteLine("this is format problem");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"This is the Person Exception:{e.Message}\n  This is the exception from Temperture {e.InnerException?.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " i caught all other exceptions...Inheritance you know");
            }

            Console.ReadKey();
        }
    }
}
