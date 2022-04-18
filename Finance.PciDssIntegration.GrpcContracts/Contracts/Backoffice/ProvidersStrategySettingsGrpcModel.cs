using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts.Backoffice
{
    [DataContract]
    public class ProvidersStrategySettingsGrpcModel
    {
        public ProvidersStrategySettingsGrpcModel()
        {
        }

        private ProvidersStrategySettingsGrpcModel(string paymentProviderName, BrandName brand, int weight,
            IReadOnlyCollection<string> supportedGeo,
            IReadOnlyCollection<string> restrictedGeo)
        {
            PaymentProviderName = paymentProviderName;
            Brand = brand;
            Weight = weight;
            SupportedGeo = supportedGeo;
            RestrictedGeo = restrictedGeo;
        }

        [DataMember(Order = 1)] public string PaymentProviderName { get; set; }
        [DataMember(Order = 2)] public BrandName Brand { get; set; }
        [DataMember(Order = 3)] public int Weight { get; set; }
        [DataMember(Order = 4)] public IReadOnlyCollection<string> SupportedGeo { get; set; }
        [DataMember(Order = 5)] public IReadOnlyCollection<string> RestrictedGeo { get; set; }

        public static ProvidersStrategySettingsGrpcModel Create(string paymentProviderName, BrandName brand, int weight,
            IReadOnlyCollection<string> supportedGeo,
            IReadOnlyCollection<string> restrictedGeo)
        {
            return new ProvidersStrategySettingsGrpcModel(paymentProviderName, brand, weight, supportedGeo,
                restrictedGeo);
        }
    }
}