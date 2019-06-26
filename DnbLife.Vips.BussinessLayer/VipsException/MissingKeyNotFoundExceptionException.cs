using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnbLife.Vips.BussinessLayer
{
    public class MissingKeyNotFoundExceptionException : Exception
    {
        public MissingKeyNotFoundExceptionException(Exception innerException) : base("There is not short URL with that key", innerException)
        {

        }
    }
}
