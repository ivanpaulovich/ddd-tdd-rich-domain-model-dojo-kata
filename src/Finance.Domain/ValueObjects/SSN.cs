namespace Finance.Domain.ValueObjects
{
    public class SSN
    {
        public string _text { get; private set; }

        public SSN(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new SSNShouldNotBeEmptyException("The 'SSN' field is required");

            this._text = text;
        }

        public override string ToString()
        {
            return _text.ToString();
        }

        public static implicit operator SSN(string text)
        {
            return new SSN(text);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is string)
            {
                return obj.ToString() == _text;
            }

            return ((SSN)obj)._text == _text;
        }

        public override int GetHashCode()
        {
            return _text.GetHashCode();
        }
    }
}
