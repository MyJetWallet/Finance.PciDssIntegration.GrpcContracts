using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts.Backoffice
{
    [DataContract]
    public class RemovePaymentProvidersStrategySettingsGrpcRequest
    {
        public RemovePaymentProvidersStrategySettingsGrpcRequest()
        {
        }

        private RemovePaymentProvidersStrategySettingsGrpcRequest(BrandName brand, string paymentProviderName)
        {
            Brand = brand;
            PaymentProviderName = paymentProviderName;
        }

        [DataMember(Order = 1)] public string PaymentProviderName { get; set; }
        [DataMember(Order = 2)] public BrandName Brand { get; set; }

        public static RemovePaymentProvidersStrategySettingsGrpcRequest Create(BrandName brand,
            string paymentProviderName)
        {
            return new RemovePaymentProvidersStrategySettingsGrpcRequest(brand, paymentProviderName);
        }
    }
}
