namespace Setu.API.PaymenGatewayHelper.Cashfree
{
    public class RequestTransferDTO
    {
        public string beneId { get; set; }
        public float amount { get; set; }
        public string transferId { get; set; }
        public string transferMode { get; set; }
        public string remarks { get; set; }
    }
}
