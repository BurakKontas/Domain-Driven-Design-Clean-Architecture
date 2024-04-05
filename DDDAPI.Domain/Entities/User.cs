namespace DDDAPI.Domain.Entities;

public class User
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!; 
}

