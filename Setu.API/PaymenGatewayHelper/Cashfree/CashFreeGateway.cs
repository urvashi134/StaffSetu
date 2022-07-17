using Newtonsoft.Json;
using Setu.Common.DTO;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Setu.API.PaymenGatewayHelper.Cashfree
{
    public class CashFreeGateway
    {
        CashFreeDetails cashFreeDetails;
        public CashFreeGateway(CashFreeDetails cashFreeDetails)
        {
            this.cashFreeDetails = cashFreeDetails;
        }
        public bool addBenificiary(AddBeneficiaryRequestDTO aaddBeneficiaryRequestDTO)
        {
            bool result = false;
            cashFreeDetails.CashFreeConnect();
            HttpResponseMessage HttpResponseMessage = null;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var myContent = JsonConvert.SerializeObject(aaddBeneficiaryRequestDTO);
                var httpContent = new StringContent(myContent, Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cashFreeDetails.token);
                HttpResponseMessage = httpClient.PostAsync(cashFreeDetails.url + "/payout/v1/addBeneficiary", httpContent).Result;
                if (HttpResponseMessage.StatusCode == HttpStatusCode.OK)
                {
                    string Response = HttpResponseMessage.Content.ReadAsStringAsync().Result;
                    AaddBeneficiaryResponse rootobject = JsonConvert.DeserializeObject<AaddBeneficiaryResponse>(Response);
                    if (rootobject.subCode == "200")
                        result = true;
                }
                else
                {
                    //logger.LogError("Issue in GetPayPalPaymentID : " + HttpResponseMessage.StatusCode + ":" + HttpResponseMessage.Content.ToString());
                }
            }
            return result;
        }

        public bool transferMoney(RequestTransferDTO requestTransferDTO)
        {
            bool result = false;
            cashFreeDetails.CashFreeConnect();
            HttpResponseMessage HttpResponseMessage = null;
            requestTransferDTO.amount = 100;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var myContent = JsonConvert.SerializeObject(requestTransferDTO);
                var httpContent = new StringContent(myContent, Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cashFreeDetails.token);
                HttpResponseMessage = httpClient.PostAsync(cashFreeDetails.url + "/payout/v1/requestTransfer", httpContent).Result;
                if (HttpResponseMessage.StatusCode == HttpStatusCode.OK)
                {
                    string Response = HttpResponseMessage.Content.ReadAsStringAsync().Result;
                    ResponseTransferMoneyDTO rootobject = JsonConvert.DeserializeObject<ResponseTransferMoneyDTO>(Response);
                    result = true;
                    if (rootobject.subCode == "200")
                        result = true;
                }
                else
                {
                    //logger.LogError("Issue in GetPayPalPaymentID : " + HttpResponseMessage.StatusCode + ":" + HttpResponseMessage.Content.ToString());
                }
            }
            return result;
        }


    }
}
