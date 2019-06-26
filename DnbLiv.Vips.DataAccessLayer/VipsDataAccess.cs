using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnbLiv.Vips.DataAccessLayer
{
    public class VipsDataAccess : IVipsDataAccess
    {
        private static List<VipsUrlData> _short = new List<VipsUrlData>();
        private bool disposing = false;
        public VipsUrlData Add(VipsUrlData url)
        {
            _short.Add(url);
            return url;
        }

        public void Dispose()
        {
            if (!disposing)
            {
                disposing = true;
                // need to dispose all the
            }
        }

        public bool ExistsKey(string key)
        {
            return _short.Any(u => u.Key == key);
        }

        public bool ExistsUrl(string url)
        {
            return _short.Any(u => u.Url == url);
        }

        public VipsUrlData FindKey(string key)
        {
            return _short.Where(u => u.Key == key).FirstOrDefault();
        }

        public VipsUrlData FindUrl(string url)
        {
            return _short.Where(u => u.Url == url).FirstOrDefault();
        }
    }
}
