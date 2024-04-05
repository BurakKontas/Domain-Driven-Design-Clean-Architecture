using DDDAPI.Application.Common.Interfaces.Authentication;

namespace DDDAPI.Application.Services.Authentication;

public class AuthenticationService(IJwtTokenGenerator jwtTokenGenerator) : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator = jwtTokenGenerator;

    public AuthenticationResult Register(string firstname, string lastname, string email, string password)
    {
        var userId = Ulid.NewUlid();
        var token = _jwtTokenGenerator.GenerateToken(userId, firstname, lastname);
        return new AuthenticationResult(Ulid.NewUlid(), firstname, lastname, email, token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Ulid.NewUlid(), "firstname", "lastname", email, "token");
    }
}