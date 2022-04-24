using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Management
{
    public class RestAPIHelper
    {
        public static HttpClient GetHttpClient()
        {

            var client = new HttpClient { BaseAddress = new Uri(ConfigurationManager.AppSettings["APIPath"]) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        /// <summary>
        /// Get async data from rest api
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        ///<param name="urlParameters"></param>
        /// <returns></returns>
        public static T GetAsync<T>(string url)
        {
            try
            {
                using (var client = GetHttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        var result = JsonConvert.DeserializeObject<T>(json);
                        return result;
                    }

                    return default(T);
                }
            }
            catch (Exception)
            {
                //logger.Information("RestAPICall failed to get data using url " + url);
                //logger.Error(ex.Message, ex);
                return default(T);
            }
        }
        /// <summary>
        /// Get async data from rest api
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="urlParameters"></param>
        /// <returns></returns>
        public static T PostAsync<T>(string url, T urlParameters)
        {
            try
            {
                using (var client = GetHttpClient())
                {
                    HttpResponseMessage response = client.PostAsJsonAsync(url, urlParameters).GetAwaiter().GetResult();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        var result = JsonConvert.DeserializeObject<T>(json);
                        return result;
                    }

                    return default(T);
                }
            }
            catch (Exception)
            {
                //logger.Information("RestAPICall failed to get data using url " + url);
                //logger.Error(ex.Message, ex);
                return default(T);
            }
        }
        public static T PutAsync<T>(string url, T urlParameters)
        {
            try
            {
                using (var client = GetHttpClient())
                {
                    HttpResponseMessage response = client.PutAsJsonAsync(url, urlParameters).GetAwaiter().GetResult();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        var result = JsonConvert.DeserializeObject<T>(json);
                        return result;
                    }

                    return default(T);
                }
            }
            catch (Exception)
            {
                //logger.Information("RestAPICall failed to get data using url " + url);
                //logger.Error(ex.Message, ex);
                return default(T);
            }
        }
    }
}
