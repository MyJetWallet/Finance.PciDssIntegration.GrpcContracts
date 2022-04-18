using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts.Backoffice
{
    [DataContract]
    public class GetPaymentProvidersStrategySettingsGrpcResponse
    {
        [DataMember(Order = 1)]
        public IReadOnlyCollection<ProvidersStrategySettingsGrpcModel> ProvidersStrategySettingsGrpcModels { get; set; }
    }
}