using System.Configuration;

namespace DnbLife.Vips.BussinessLayer
{
    public class VipsConfigManager
    {
        public static int CacheTimeout
        {
            get
            {
                int cacheTimeout;
                if (!int.TryParse(ConfigurationManager.AppSettings["CaheTimeout"], out cacheTimeout))
                {
                    cacheTimeout = 5;
                }
                return cacheTimeout;
            }
        }

        public static int KeyLength
        {
            get
            {
                int keyLength;
                if (!int.TryParse(ConfigurationManager.AppSettings["KeyLength"], out keyLength))
                {
                    keyLength = 6;
                }
                return keyLength;
            }
        }

        public static string ApiUrl
        {
            get
            {
                return (ConfigurationManager.AppSettings["ApiUrl"]);

            }
        }
    }
}
