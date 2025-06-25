using ErrorOr;
using MediatR;
using Project.Application.Common.Interfaces;
using Project.Domain.Accounts;

namespace Project.Application.Accounts.Queries.GetAccount;

public class GetAccountQueryHandler : IRequestHandler<GetAccountQuery, ErrorOr<Account>>
{
    private readonly IAccountsRepository _accountsRepository;

    public GetAccountQueryHandler(IAccountsRepository accountsRepository)
    {
        _accountsRepository = accountsRepository;
    }

    public async Task<ErrorOr<Account>> Handle(GetAccountQuery request, CancellationToken cancellationToken)
    {
        var account = await _accountsRepository.GetAccountAsync(request.accountId);

        return account is null ? Error.NotFound(description: "Account not found") : account;
    }
}