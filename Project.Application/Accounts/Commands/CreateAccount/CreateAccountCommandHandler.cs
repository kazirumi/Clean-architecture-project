using ErrorOr;
using MediatR;

namespace Project.Application.Accounts.Commands.CreateAccount;

public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, ErrorOr<int>>
{
    public async Task<ErrorOr<int>> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        return 124;
    }
}