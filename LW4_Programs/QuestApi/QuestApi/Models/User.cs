using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required, MinLength(2)]
    public string FullName { get; set; } = "";

    [Required, EmailAddress]
    public string Email { get; set; } = "";
}
