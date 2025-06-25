using ErrorOr;
using MediatR;
using Project.Application.Common.Interfaces;
using Project.Domain.Accounts;

namespace Project.Application.Accounts.Commands.CreateAccount;

public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, ErrorOr<Account>>
{
    private readonly IAccountsRepository _accountsRepository;
    // private readonly IUnitOfWork _unitOfWork;

    public CreateAccountCommandHandler(IAccountsRepository accountsRepository)
    {
        // , IUnitOfWork unitOfWork
        _accountsRepository = accountsRepository;
        // _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Account>> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        var account = new Account
        {
            Name = request.AccountName,
            Type = request.AccountType
        };

        await _accountsRepository.AddAccountAsync(account);

        // await _unitOfWork.CommitChangesAsync();
        
        return account;
    }
}

