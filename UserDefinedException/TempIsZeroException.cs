using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    /// <summary>
    /// Exception when the temperture is 0
    /// </summary>
    class TempIsZeroException :Exception
    {
        
        public TempIsZeroException()
        {

        }
        public TempIsZeroException(string message, Exception innerException):base(message,innerException)
        {

        }
        public TempIsZeroException(string message) : base(message)
        {
        }
    }

}
