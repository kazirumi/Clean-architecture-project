using Project.Domain.Accounts;

namespace Project.Application.Common.Interfaces;

public interface IAccountsRepository
{
    void AddAccount(Account account); 
}