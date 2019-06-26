using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnbLife.Vips.BussinessLayer
{
    public interface IShortUrlManager
    {
        String AddShortUrl(string Url);
        String GetUrl(String ShortUrlKey);
    }
}
