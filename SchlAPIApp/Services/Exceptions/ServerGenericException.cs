namespace SchlAPIApp.Services.Exceptions
{
    public class ServerGenericException : Exception
    {
        public ServerGenericException(string s) 
            : base(s)
        {
        }
    }
}
