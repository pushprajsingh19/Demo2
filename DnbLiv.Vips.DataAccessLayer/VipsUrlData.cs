using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnbLiv.Vips.DataAccessLayer
{
    public class VipsUrlData
    {
        public String Key { get; set; }

        public String Url { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }
    }
}
