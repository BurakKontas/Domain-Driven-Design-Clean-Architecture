using DDDAPI.Domain.Entities;

namespace DDDAPI.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);