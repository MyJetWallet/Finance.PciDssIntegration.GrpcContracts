using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts
{
    [DataContract]
    public class GetPaymentSystemResponse
    {
        [DataMember(Order = 1)] public PaymentProviders PaymentSystem { get; set; }

        public static GetPaymentSystemResponse Create(PaymentProviders providers)
        {
            return new GetPaymentSystemResponse
            {
                PaymentSystem = providers
            };
        }
    }

    [DataContract]
    public class SetPaymentSystemRequest
    {
        [DataMember(Order = 1)] public PaymentProviders PaymentSystem { get; set; }

        public static SetPaymentSystemRequest Create(PaymentProviders providers)
        {
            return new SetPaymentSystemRequest
            {
                PaymentSystem = providers
            };
        }
    }
}