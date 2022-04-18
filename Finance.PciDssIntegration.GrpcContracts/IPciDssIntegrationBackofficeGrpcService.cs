using System.ServiceModel;
using System.Threading.Tasks;
using Finance.PciDssIntegration.GrpcContracts.Contracts.Backoffice;

namespace Finance.PciDssIntegration.GrpcContracts
{
    [ServiceContract(Name = "PciDssIntegrationBackofficeGrpcService")]
    public interface IPciDssIntegrationBackofficeGrpcService
    {
        [OperationContract]
        ValueTask<GetAvailablePaymentProvidersGrpcResponse> GetAvailablePaymentProvidersAsync(
            GetAvailablePaymentProvidersGrpcRequest request);

        [OperationContract]
        ValueTask<GetPaymentProvidersStrategySettingsGrpcResponse> GetPaymentProvidersStrategySettingsAsync(
            GetPaymentProvidersStrategySettingsGrpcRequest request);

        [OperationContract]
        ValueTask SetPaymentProvidersStrategySettingsAsync(
            SetPaymentProvidersStrategySettingsGrpcRequest request);

        [OperationContract]
        ValueTask<GetSupportedBrandsGrpcResponse> GetSupportedBrandsAsync(
            GetSupportedBrandsGrpcRequest request);

        [OperationContract]
        ValueTask RemovePaymentProvidersStrategySettingsAsync(
            RemovePaymentProvidersStrategySettingsGrpcRequest request);
    }
}