namespace Setu.API.PaymenGatewayHelper.Cashfree
{
    public class Data
    {
        public string referenceId { get; set; }
        public string utr { get; set; }
        public int acknowledged { get; set; }
    }

    public class ResponseTransferMoneyDTO
    {
        public string status { get; set; }
        public string subCode { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }


}
