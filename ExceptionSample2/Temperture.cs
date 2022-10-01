using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSample3
{
    public class Temperture
    {
        #region Max and Min Normal Person Temperture
        const double HIGH = 42;
        const double LOW = 35.5;
        #endregion

        #region members
        private double temperture;
        #endregion

        #region C'tor
        /// <summary>
        /// יצירת אובייקט מסוג טמפרטורה
        /// </summary>
        /// <param name="temp">טמפרטורה</param>
        /// <exception cref="ArgumentOutOfRangeException">ייזרק אם הטמפרטורה גבוהה מ42 או נמוכה מ35.5</exception>
        public Temperture(double temp)
        {
            #region Check for valid input
            if (temp > HIGH || temp < LOW)
                #region exception
                throw new ArgumentOutOfRangeException("Temp Value is not valid");
            #endregion
            #endregion
            temperture = temp;
        }
        #endregion

        #region Getters and Setters
        public double GetTemperture()
        {
            return temperture;
        }


        /// <summary>
        /// עדכון טמפרטורה
        /// </summary>
        /// <param name="temp">טמפרטורה</param>
        /// <exception cref="ArgumentOutOfRangeException">ייזרק אם הטמפרטורה גבוהה מ42 או נמוכה מ35.5</exception>
        public void SetTemperture(double temp)
        {
            #region Check for valid input
            if (temp > HIGH || temp < LOW)
                #region exception
                throw new ArgumentOutOfRangeException("Temp Value is not valid");
            #endregion
            #endregion
            temperture = temp;
        }
        #endregion
    }
}
