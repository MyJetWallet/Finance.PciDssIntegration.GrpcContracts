using Destructurama.Attributed;
using System;
using System.Runtime.Serialization;

namespace Finance.PciDssIntegration.GrpcContracts.Contracts
{
    public enum BrandName
    {
        Monfex,
        HandelPro,
        Allianzmarket
    }

    [DataContract]
    public class MakeDepositRequest
    {
        [LogMasked(ShowFirst = 6, ShowLast = 4, PreserveLength = true)]
        [DataMember(Order = 1)] public string BankNumber { get; set; }
        [NotLogged]
        [DataMember(Order = 2)] public string Cvv { get; set; }
        [NotLogged]
        [DataMember(Order = 3)] public DateTime ExpirationDate { get; set; }
        [LogMasked(ShowFirst = 1, ShowLast = 1, PreserveLength = true)]
        [DataMember(Order = 4)] public string FullName { get; set; }
        [DataMember(Order = 5)] public double Amount { get; set; }
        [DataMember(Order = 6)] public string PostalCode { get; set; }
        [DataMember(Order = 7)] public string Country { get; set; }
        [DataMember(Order = 8)] public string City { get; set; }
        [DataMember(Order = 9)] public string Address { get; set; }
        [DataMember(Order = 10)] public string TraderId { get; set; }
        [DataMember(Order = 11)] public string AccountId { get; set; }
        [DataMember(Order = 12)] public string ClientIp { get; set; }
        [Obsolete("You should use Brand", false)]
        [DataMember(Order = 13)] public BrandName BrandName { get; set; }
        [DataMember(Order = 14)] public string Brand { get; set; }
        [DataMember(Order = 15)] public string PhoneNumber { get; set; }
        [DataMember(Order = 16)] public string KycVerified { get; set; }
        [DataMember(Order = 17)] public double TotalDeposit { get; set; }
        [DataMember(Order = 18)] public string Source { get; set; }
    }

    [DataContract]
    public class MakeDepositResponse
    {
        [DataMember(Order = 1)] public string SecureRedirectUrl { get; set; }
        [DataMember(Order = 2)] public DepositRequestStatus Status { get; set; }

        public static MakeDepositResponse Create(string redirectUrl, DepositRequestStatus status)
        {
            return new MakeDepositResponse
            {
                SecureRedirectUrl = redirectUrl,
                Status = status
            };
        }
    }
}