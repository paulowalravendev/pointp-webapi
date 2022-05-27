namespace PointPWebApi.Application.Services;

public interface IEncryptionService
{
    string EncryptPassword(string password);
}