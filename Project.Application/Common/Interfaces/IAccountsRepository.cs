using Project.Domain.Accounts;

namespace Project.Application.Common.Interfaces;

public interface IAccountsRepository
{
    Task AddAccountAsync(Account account); 
    Task<Account?> GetAccountAsync(int accountId); 
}