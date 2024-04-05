namespace DDDAPI.Contracts.Authentication;

public record AuthenticationResponse
(
    Ulid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);