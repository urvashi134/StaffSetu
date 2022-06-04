using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;


namespace Setu.API.PaymenGatewayHelper.Cashfree
{
    public class CashFreeDetails
    {
        private readonly IConfiguration config;
        public CashFreeDetails(IConfiguration config)
        {
            this.config = config;
        }
        public string token { get; set; }
        public string url { get; set; }
        public string username {get;set;}
        public string password { get; set; }

        public void CashFreeConnect()
        {
            if(username == null)
            {
                username = config["CashFreeGatewayUsername"];
            }

            if (password == null)
            {
                password = config["CashFreeGatewayPassword"];
            }
            if (url == null)
            {
                url = config["PaymentGatewayBaseUrl"];
            }
            HttpClient client = new HttpClient();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            client.BaseAddress = new Uri(url + "/payout/v1/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Client-Id", username);
            client.DefaultRequestHeaders.Add("X-Client-Secret", password);

            List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>("grant_type", "client_credentials");
            keyValuePairs.Add(keyValuePair);
            var val = client.PostAsync("authorize", new FormUrlEncodedContent(keyValuePairs)).Result;
            string sData = val.Content.ReadAsStringAsync().Result;
            AuthResponse rootobject = JsonConvert.DeserializeObject<AuthResponse>(sData);
            token = rootobject.data.token;
        }
    }
}
