using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using PointPWebApi.Application.Services;

namespace PointPWebApi.Infrastructure.Services;

public class EncryptionService : IEncryptionService
{
    public string EncryptPassword(string password)
    {
        var salt = new byte[128 / 8];
        using var rngCsp = RandomNumberGenerator.Create();
        rngCsp.GetNonZeroBytes(salt);
        return Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
    }
}