using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region  EXAMPLE OF BUBBLE UP EXCEPTION
#endregion
namespace ExceptionSample3
{
    public class Person
    {
        #region members
        private string pName;//person name
        private Temperture t;
        #endregion
        
        public Person(string pName)
        {
            this.pName = pName;
            //EXCEPTION  CAUGHT IN THE CALLER FUNCTION
            try
            {
                //TEMPERTURE CLASS THROWS EXCEPTION BECAUSE TEMP CANNOT BE UNDER 35.5 OR MORE THAN 42
                t = new Temperture(31);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message[1] + " Tried to put 31 celsius as temperture- Caught it at Person Class");
            }


        }
        
        public Person(string pName, double temp)
        {
            //EXCEPTION IS NOT HANDLED IN THE CALLER FUNCTION AND BUBBLE UP TO THE CALLER'S CALL
            if (pName.Length > 4)
                    throw new FormatException("name must be under 4 letters");

            this.pName = pName;
            //THIS LINE MIGHT CAUSE AN EXCEPTION IF THE TEMP IS MORE THAN 42 OR LESS THAN 35.5
            //BUT IT IS NOT COUGHT IN THIS FUNCTION CALL AND BUBBLE UP TO THE CALLER'S CALL
            t = new Temperture(temp);
        }

        public Person(double temp)
        {
            this.pName = "Kuku";

            //Catch the Exception and throw a new one (but bubble the original exception)
            try
            {
                t = new Temperture(temp);
                
            }
            catch(ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("ooooops...something is wrong", e);
            }

        }

        public Temperture GetTemperture()
        {
            return  t;
        }

        public string GetName()
        {
            return pName;
        }
    }
}
