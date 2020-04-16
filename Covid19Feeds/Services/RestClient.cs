
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Covid19Feeds.Services
{
    public sealed class RestClient : IRestClient
    {
        private static RestClient _restClientInstance = null;
       

        public static RestClient RestClientInstance
        {
            get
            {
                if (_restClientInstance == null)
                {
                    _restClientInstance = new RestClient();
                }
                return _restClientInstance;
            }

        }
        private HttpClient client;
        private RestClient()
        {
           
        }


        private HttpClient GetHttpClient()
        {
            try
            {
                client = new HttpClient();
                client.MaxResponseContentBufferSize = 1024000;
                string authData = string.Format("{0}:{1}", "", "");
                string authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
                return client;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.StackTrace);
            }
            finally
            {

            }


        }





        private readonly Action<HttpStatusCode, string> _defaultErrorHandler = (statusCode, body) =>
        {
            if (statusCode < HttpStatusCode.OK || statusCode >= HttpStatusCode.BadRequest)
            {
                Debug.WriteLine(string.Format("Request responded with status code={0}, response={1}", statusCode, body));
                throw new RestClientException(statusCode, body);
            }
        };


        private void HandleIfErrorResponse(HttpStatusCode statusCode, string content, Action<HttpStatusCode, string> errorHandler = null)
        {
            if (errorHandler != null)
            {
                errorHandler(statusCode, content);
            }
            else
            {
                _defaultErrorHandler(statusCode, content);
            }
        }


        private T GetValue<T>(String value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }

        private HttpContent GetHttpContent(object payload)
        {
            try
            {
                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return content;
            }
            catch (Exception ex)
            {

                throw new Exception("Problem in Serializing Object");
            }
        }


        #region HttpMethods
        public async Task<T> GetAsync<T>(string Url, bool SetAuth = false)
        {
            try
            {
                if (CrossConnectivity.Current.IsConnected)
                {
                    var client = GetHttpClient();
                    var response = await client.GetAsync(Url);
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                   HandleIfErrorResponse(response.StatusCode, json);
                    if (typeof(T) == typeof(string))
                    {
                        return GetValue<T>(json);
                    }
                    var x = JsonConvert.DeserializeObject<T>(json);
                    return x;
                }
                else
                {
                   // DependencyService.Get<ISnackBar>().ShowSnackBar("Please Connect To The Internet");
                }
                
            }
            catch (System.Net.WebException ex)
            {

                throw ex;
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine("Error in GET Request :" + ex.Message);
            }
            return default(T);
        }



        public async Task<T> PostAsync<T>(string Url, bool SetAuth = false, object payload = null)
        {
            try
            {
                if (CrossConnectivity.Current.IsConnected)
                {
                    var client = GetHttpClient();
                    var response = await client.PostAsync(Url, GetHttpContent(payload)).ConfigureAwait(false);
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            HandleIfErrorResponse(response.StatusCode, json);
                    if (typeof(T) == typeof(string))
                    {
                        return GetValue<T>(json);
                    }
                    var x = JsonConvert.DeserializeObject<T>(json);
                    return x;
                }
                else
                {
                   // DependencyService.Get<ISnackBar>().ShowSnackBar("Please Connect To The Internet");
                }
                
            }
            catch (System.Net.WebException ex)
            {

                throw ex;
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine("Error in POST Request :" + ex.Message);
            }
            return default(T);
        }



        public async Task<T> PutAsync<T>(string Url, bool SetAuth = false, object payload = null)
        {
            try
            {
                if (CrossConnectivity.Current.IsConnected)
                {
                    var client = GetHttpClient();
                    var response = await client.PutAsync(Url, GetHttpContent(payload));
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    HandleIfErrorResponse(response.StatusCode, json);
                    if (typeof(T) == typeof(string))
                    {
                        return GetValue<T>(json);
                    }
                    var x = JsonConvert.DeserializeObject<T>(json);
                    return x;
                }
                else
                {
                    //DependencyService.Get<ISnackBar>().ShowSnackBar("Please Connect To The Internet");
                }
                
            }
            catch (System.Net.WebException ex)
            {

                throw ex;
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine("Error in POST Request :" + ex.Message);
            }
            return default(T);
        }



        public async Task<T> DeleteAsync<T>(string Url, bool SetAuth = false)
        {
            try
            {
                if (CrossConnectivity.Current.IsConnected)
                {
                    var client = GetHttpClient();
                    var response = await client.DeleteAsync(Url);
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    HandleIfErrorResponse(response.StatusCode, json);
                    if (typeof(T) == typeof(string))
                    {
                        return GetValue<T>(json);
                    }
                    var x = JsonConvert.DeserializeObject<T>(json);
                    return x;
                }
                else
                {
                    //DependencyService.Get<ISnackBar>().ShowSnackBar("Please Connect To The Internet");
                }
                
            }
            catch (System.Net.WebException ex)
            {

                throw ex;
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine("Error in Delete Request :" + ex.Message);
            }
            return default(T);
        }
        #endregion
    }
}
