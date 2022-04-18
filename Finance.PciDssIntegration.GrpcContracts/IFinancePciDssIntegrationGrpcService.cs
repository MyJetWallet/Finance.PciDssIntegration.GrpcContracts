using System.ServiceModel;
using System.Threading.Tasks;
using Finance.PciDssIntegration.GrpcContracts.Contracts;

namespace Finance.PciDssIntegration.GrpcContracts
{
    [ServiceContract(Name = "FinancePciDssIntegrationGrpcService")]
    public interface IFinancePciDssIntegrationGrpcService
    {
        [OperationContract(Action = "MakeDepositAsync")]
        ValueTask<MakeDepositResponse> MakeDepositAsync(MakeDepositRequest request);
        
        [OperationContract(Action = "GetActivePaymentSystem")]
        ValueTask<GetPaymentSystemResponse> GetActivePaymentSystemAsync();
        
        [OperationContract(Action = "SetActivePaymentSystem")]
        ValueTask SetActivePaymentSystemAsync(SetPaymentSystemRequest request);

        [OperationContract(Action = "DecodeInfoAsync")]
        ValueTask<DecodeInfoResponse> DecodeInfoAsync(DecodeInfoRequest request);
    }
}