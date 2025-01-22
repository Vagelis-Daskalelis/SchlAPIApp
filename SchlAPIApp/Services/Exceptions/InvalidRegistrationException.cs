namespace SchlAPIApp.Services.Exceptions
{
    public class InvalidRegistrationException : Exception
    {
        public InvalidRegistrationException(string s)
            : base(s)
        {
        }
    }
}
