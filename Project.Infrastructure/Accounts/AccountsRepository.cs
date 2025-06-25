using Project.Application.Common.Interfaces;
using Project.Domain.Accounts;

namespace Project.Infrastructure.Accounts;

public class AccountsRepository : IAccountsRepository
{
    private static readonly List<Account> _accounts = new();

    public Task AddAccountAsync(Account account)
    {
        _accounts.Add(account);
        
        return Task.CompletedTask;
    }

    public Task<Account?> GetAccountAsync(int accountId)
    {
        return  Task.FromResult(_accounts.FirstOrDefault(account=>account.Id == accountId));
    }
}