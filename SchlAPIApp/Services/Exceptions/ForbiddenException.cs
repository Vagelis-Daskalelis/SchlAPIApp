namespace SchlAPIApp.Services.Exceptions
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException(string s)
            : base(s)
        {
        }
    }
}
