namespace Finance.PciDssIntegration.GrpcContracts.Contracts
{
    public enum DepositRequestStatus
    {
        Success,
        InvalidCardNumber,
        InvalidCredentials,
        UnsupportedCardType,
        MaxDepositAmountExceeded,
        MinDepositAmountExceeded,
        PaymentDeclined,
        ServerError,
        PaymentDisabled
    }
}