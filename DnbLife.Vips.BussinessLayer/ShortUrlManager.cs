using DnbLife.Vips.BussinessLayer.VipsException;
using DnbLiv.Vips.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnbLife.Vips.BussinessLayer
{
    public class ShortUrlManager : IShortUrlManager
    {
        private IVipsDataAccess _dataRepository;

        public ShortUrlManager(IVipsDataAccess dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public string AddShortUrl(string Url)
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                Url = Url.Trim().ToLower();
            }
            try
            {
                var url = new Uri(Url);
            }
            catch (Exception ex)
            {
               throw new InvalidUrlException(ex);
            }
            String newKey = null;
            while (string.IsNullOrEmpty(newKey))
            {
                if (!_dataRepository.ExistsUrl(Url))
                {
                    newKey = Guid.NewGuid().ToString("N").Substring(0, VipsConfigManager.KeyLength).ToLower();
                    _dataRepository.Add(new VipsUrlData { Key = newKey, Url = Url, DateCreated = DateTime.Now });
                }
                else
                {
                    var shortUrl = _dataRepository.FindUrl(Url);
                    if (shortUrl != null)
                    {
                        newKey = shortUrl.Key;
                    }
                }
            }
            return newKey;
        }

        public string GetUrl(string ShortUrlKey)
        {
            var url = _dataRepository.FindKey(ShortUrlKey);
            if (url != null)
            {
                return url.Url;
            }
            else
            {
                throw new MissingKeyNotFoundExceptionException(null);
            }
        }
    }
}
