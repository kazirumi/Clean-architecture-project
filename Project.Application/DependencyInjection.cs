using Microsoft.Extensions.DependencyInjection;
using Project.Application.Services;

namespace Project.Application;

public static class DependencyInjection
{
    public static  IServiceCollection AddApplication(this IServiceCollection services)
    {
        // services.AddScoped<IAccountsService, AccountsService>();

        return services;
    }
}