using DDDAPI.Domain.Entities;

namespace DDDAPI.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}

