namespace Finance.DomainTests
{
    using Xunit;
    using Finance.Domain.Accounts;
    using System;

    public class DebitTests
    {
        [Fact]
        public void Debit_Should_Be_Loaded()
        {
            Debit Debit = Debit.Load(
                Guid.Empty,
                Guid.Empty,
                100,
                DateTime.Today);

            Assert.Equal(Guid.Empty, Debit.Id);
            Assert.Equal(Guid.Empty, Debit.AccountId);
            Assert.Equal(100, Debit.Amount);
            Assert.Equal(DateTime.Today, Debit.TransactionDate);
        }
    }
}
