namespace UnitTests.UseCasesTests.Register
{
    using System;
    using Application.UseCases;
    using Xunit;

    public sealed class RegisterTests
    {
        [Fact]
        public void GivenNullInput_ThrowsException()
        {
            var register = new Register();
            Assert.ThrowsAsync<Exception>(async () => await register.Execute(null));
        }
    }
}
