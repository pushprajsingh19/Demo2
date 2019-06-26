using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnbLiv.Vips.DataAccessLayer
{
    public interface IVipsDataAccess
    {
        bool ExistsKey(String key);
        bool ExistsUrl(String url);
        VipsUrlData FindKey(String key);
        VipsUrlData FindUrl(String url);
        VipsUrlData Add(VipsUrlData url);
    }
}
