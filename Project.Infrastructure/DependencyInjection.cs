using Microsoft.Extensions.DependencyInjection;
using Project.Application.Common.Interfaces;
using Project.Infrastructure.Accounts;

namespace Project.Infrastructure;

public static class DependencyInjection
{
    public static  IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IAccountsRepository, AccountsRepository>();
        return services;
    }
}