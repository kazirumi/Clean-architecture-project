using System.ComponentModel.DataAnnotations;

namespace Project.Domain.Accounts;

public class Account
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Type { get; set; }
    
}