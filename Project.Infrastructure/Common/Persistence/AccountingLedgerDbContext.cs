using Microsoft.EntityFrameworkCore;
using Project.Application.Common.Interfaces;
using Project.Domain.Accounts;

namespace Project.Infrastructure.Common.Persistence;

public class AccountingLedgerDbContext: DbContext,IUnitOfWork
{
    public AccountingLedgerDbContext(DbContextOptions<AccountingLedgerDbContext> options) : base(options)
    {
        
    }

    public DbSet<Account> Accounts { get; set; } = null!;
    public async Task CommitChangesAsync()
    {
        await base.SaveChangesAsync();
    }
}