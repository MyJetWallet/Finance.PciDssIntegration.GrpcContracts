using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts.Backoffice
{
    [DataContract]
    public class SetPaymentProvidersStrategySettingsGrpcRequest
    {
        [DataMember(Order = 1)]
        public ProvidersStrategySettingsGrpcModel ProvidersStrategySettingsGrpcModel { get; set; }
    }
}