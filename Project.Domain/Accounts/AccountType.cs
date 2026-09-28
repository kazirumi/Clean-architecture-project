using Ardalis.SmartEnum;

namespace Project.Domain.Accounts;

public class AccountType: SmartEnum<AccountType>
{
    public static readonly AccountType Asset = new (nameof(Asset), 0);
    public static readonly AccountType Liability = new (nameof(Liability), 1);
    public static readonly AccountType Equity = new (nameof(Equity), 2);
    public static readonly AccountType Revenue = new (nameof(Revenue), 3);
    public static readonly AccountType Expense = new (nameof(Expense), 4);
    public AccountType(string name, int value) : base(name, value)
    {
    }
}