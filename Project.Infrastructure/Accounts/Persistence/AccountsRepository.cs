using Microsoft.EntityFrameworkCore;
using Project.Application.Common.Interfaces;
using Project.Domain.Accounts;
using Project.Infrastructure.Common.Persistence;

namespace Project.Infrastructure.Accounts.Persistence;

public class AccountsRepository : IAccountsRepository
{
    private readonly AccountingLedgerDbContext _dbContext;

    public AccountsRepository(AccountingLedgerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAccountAsync(Account account)
    {
        await _dbContext.Accounts.AddAsync(account);
        
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Account?> GetAccountAsync(int accountId)
    {
        return  await _dbContext.Accounts.FindAsync(accountId);
    }
}