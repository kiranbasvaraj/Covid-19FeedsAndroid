using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Feeds.Services
{
    public interface IRestClient
    {
        Task<T> GetAsync<T>(string Url, bool SetAuth = false);
        Task<T> PostAsync<T>(string Url, bool SetAuth = false, object payload = null);
        Task<T> PutAsync<T>(string Url, bool SetAuth = false, object payload = null);
        Task<T> DeleteAsync<T>(string Url, bool SetAuth = false);
    }
}
