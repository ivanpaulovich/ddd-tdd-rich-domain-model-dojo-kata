namespace Finance.Domain.ValueObjects
{
    public sealed class Name
    {
        private string _text;

        public Name(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new NameShouldNotBeEmptyException("The 'Name' field is required");

            _text = text;
        }

        public override bool Equals(object obj)
        {
            return ((Name)obj)._text == _text;
        }
    }
}
