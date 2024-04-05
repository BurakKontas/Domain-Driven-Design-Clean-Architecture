namespace DDDAPI.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(Ulid userId, string firstName, string lastName);
}

