using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts
{

    [DataContract]
    public class DecodeInfoRequest
    {
        [DataMember(Order = 1)] public string TraderId { get; set; }
        [DataMember(Order = 2)] public string InfoToDecode { get; set; }
        [DataMember(Order = 3)] public string BrandName { get; set; }
        [DataMember(Order = 4)] public string PaymentProvider { get; set; }
    }

    [DataContract]
    public class DecodeInfoResponse
    {
        [DataMember(Order = 1)] public string DecodedInfo { get; set; }
        [DataMember(Order = 2)] public DepositRequestStatus Status { get; set; }

        public static DecodeInfoResponse Create(string info, DepositRequestStatus status)
        {
            return new DecodeInfoResponse
            {
                DecodedInfo = info,
                Status = status
            };
        }
    }
}