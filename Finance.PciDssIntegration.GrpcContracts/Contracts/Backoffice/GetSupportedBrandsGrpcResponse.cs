using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts.Backoffice
{
    [DataContract]
    public class GetSupportedBrandsGrpcResponse
    {
        [DataMember(Order = 1)] public IReadOnlyCollection<BrandName> BrandNames { get; set; }

        public GetSupportedBrandsGrpcResponse()
        {
        }

        private GetSupportedBrandsGrpcResponse(params BrandName[] brandName)
        {
            BrandNames = brandName.ToList();
        }

        public static GetSupportedBrandsGrpcResponse Create(params BrandName[] brandName)
        {
            return new GetSupportedBrandsGrpcResponse(brandName);
        }
    }
}