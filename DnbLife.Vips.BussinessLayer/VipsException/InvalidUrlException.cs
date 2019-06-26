using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnbLife.Vips.BussinessLayer.VipsException
{
    public class InvalidUrlException : Exception
    {
        public InvalidUrlException(Exception innerException) : base("The URL address you provided is not valid URL", innerException)
        {

        }
    }
}
