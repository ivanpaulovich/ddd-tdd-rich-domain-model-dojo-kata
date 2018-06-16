namespace Finance.Domain.ValueObjects
{
    public class InvalidSSNException : DomainException
    {
        internal InvalidSSNException(string message)
            : base(message)
        { }
    }
}
