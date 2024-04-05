namespace DDDAPI.Application.Services.Authentication;

public record AuthenticationResult(
    Ulid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);