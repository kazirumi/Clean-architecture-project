using ErrorOr;
using MediatR;
using Project.Domain.Accounts;

namespace Project.Application.Accounts.Commands.CreateAccount;

public record CreateAccountCommand(string AccountName, AccountType AccountType): IRequest<ErrorOr<Account>>;