using NUnit.Framework;
using SimpleTrading.TestTools.Grpc;

namespace Finance.PciDssIntegration.GrpcContracts.Test
{
    public class TestGrpcCommonMistakes
    {
        [Test]
        public void BaseTest()
        {
            var assembly = typeof(IPciDssIntegrationBackofficeGrpcService).Assembly;
            assembly.TestGrpcContracts();
        }
    }
}