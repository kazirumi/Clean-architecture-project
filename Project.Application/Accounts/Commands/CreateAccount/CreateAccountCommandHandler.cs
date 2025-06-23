using MediatR;

namespace Project.Application.Accounts.Commands.CreateAccount;

public class CreateAccountCommandHandler: IRequestHandler<CreateAccountCommand, int>
{
    public Task<int> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(123);
    }
}