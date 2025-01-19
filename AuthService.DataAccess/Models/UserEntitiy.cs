namespace AuthService.DataAccess.Models;

public class UserEntitiy
{
    public required Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Login { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public bool IsActive { get; set; }
}
