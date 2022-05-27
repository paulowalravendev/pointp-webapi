namespace PointPWebApi.Application.Exceptions;

public class UserEmailUnavailableException : Exception
{
    public UserEmailUnavailableException(string email) : base($"Email {email} is unavailable")
    {
    }
}