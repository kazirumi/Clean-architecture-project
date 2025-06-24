using ErrorOr;
using MediatR;
using Project.Application.Common.Interfaces;
using Project.Domain.Accounts;

namespace Project.Application.Accounts.Commands.CreateAccount;

public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, ErrorOr<Account>>
{
    private readonly IAccountsRepository _accountsRepository;

    public CreateAccountCommandHandler(IAccountsRepository accountsRepository)
    {
        _accountsRepository = accountsRepository;
    }

    public async Task<ErrorOr<Account>> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        var account = new Account
        {
            Id = 123
        };

        _accountsRepository.AddAccount(account);
        
        return account;
    }
}

