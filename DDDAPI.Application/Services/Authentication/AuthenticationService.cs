using DDDAPI.Application.Common.Interfaces.Authentication;
using DDDAPI.Application.Common.Interfaces.Persistence;
using DDDAPI.Domain.Entities;

namespace DDDAPI.Application.Services.Authentication;

public class AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository) : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator = jwtTokenGenerator;
    private readonly IUserRepository _userRepository = userRepository;

    public AuthenticationResult Register(string firstname, string lastname, string email, string password)
    {
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User already exists");
        }

        var user = new User
        {
            FirstName = firstname,
            LastName = lastname,
            Email = email,
            Password = password
        };

        _userRepository.Add(user);

        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        var user = _userRepository.GetUserByEmail(email);
        if (user is null)
        {
            throw new Exception("User not found");
        }

        if (user.Password != password)
        {
            throw new Exception("Invalid password");
        }

        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }
}