namespace Setu.API.PaymenGatewayHelper.Cashfree
{
    public class AuthResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public string subCode { get; set; }
        public data data { get; set; }

    }

    public class data
    {
        public string token { get; set; }
        public int expiry { get; set; }
    }
}
