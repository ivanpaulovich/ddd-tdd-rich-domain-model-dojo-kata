namespace Finance.Domain.Accounts
{
    using Finance.Domain.ValueObjects;

    public interface ITransaction
    {
        Amount Amount { get; }
        string Description { get; }
    }
}
