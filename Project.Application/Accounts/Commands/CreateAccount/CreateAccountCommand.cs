using MediatR;

namespace Project.Application.Accounts.Commands.CreateAccount;

public record CreateAccountCommand(string AccountName, string AccountType): IRequest<int>;