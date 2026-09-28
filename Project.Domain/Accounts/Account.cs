using System.ComponentModel.DataAnnotations;

namespace Project.Domain.Accounts;

public class Account
{
    public int Id { get; }
    public string Name { get; private set;  }
    public AccountType Type { get; private set; }

    public Account(string name,
        AccountType type)
    {
        Name = name;
        Type = type;
    }

    private Account()
    {
        // for EF Core
    }
}