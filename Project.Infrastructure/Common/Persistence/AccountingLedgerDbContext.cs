using Microsoft.EntityFrameworkCore;
using Project.Domain.Accounts;

namespace Project.Infrastructure.Common.Persistence;

public class AccountingLedgerDbContext: DbContext
{
    public AccountingLedgerDbContext(DbContextOptions<AccountingLedgerDbContext> options) : base(options)
    {
        
    }

    public DbSet<Account> Accounts { get; set; } = null!;
}