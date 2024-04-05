using DDDAPI.Application.Common.Interfaces.Persistence;
using DDDAPI.Domain.Entities;

namespace DDDAPI.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> Users = [];

    public void Add(User user)
    {
        Users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return Users.SingleOrDefault(u => u.Email == email);
    }
}

