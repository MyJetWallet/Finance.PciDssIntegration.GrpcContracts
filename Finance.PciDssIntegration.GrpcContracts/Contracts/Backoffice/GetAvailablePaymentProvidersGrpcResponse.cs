using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts.Backoffice
{
    [DataContract]
    public class GetAvailablePaymentProvidersGrpcResponse
    {
        [DataMember(Order = 1)] public IReadOnlyCollection<string> AvailablePaymentProviders { get; set; }
    }
}