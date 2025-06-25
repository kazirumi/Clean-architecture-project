using ErrorOr;
using MediatR;
using Project.Domain.Accounts;

namespace Project.Application.Accounts.Commands.CreateAccount;

public record CreateAccountCommand(string AccountName, string AccountType): IRequest<ErrorOr<Account>>;