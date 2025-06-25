using ErrorOr;
using MediatR;
using Project.Domain.Accounts;

namespace Project.Application.Accounts.Queries.GetAccount;

public record GetAccountQuery(int accountId): IRequest<ErrorOr<Account>>;