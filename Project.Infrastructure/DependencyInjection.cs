using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Application.Common.Interfaces;
using Project.Infrastructure.Accounts;
using Project.Infrastructure.Accounts.Persistence;
using Project.Infrastructure.Common.Persistence;

namespace Project.Infrastructure;

public static class DependencyInjection
{
    public static  IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<AccountingLedgerDbContext>(options => options.UseSqlServer("Server=NADIA;Database=AccountingLedger;Integrated Security=true;TrustServerCertificate=true;"));
        services.AddScoped<IAccountsRepository, AccountsRepository>();
        return services;
    }
}