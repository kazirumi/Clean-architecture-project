using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Accounts.Commands.CreateAccount;
using Project.Contracts.Accounts;

namespace Project.Api.Controllers;

[ApiController]
[Route("accounts")]
public class AccountsController : ControllerBase
{
    public readonly ISender _mediator;

    public AccountsController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAccount(CreateAccountRequest request)
    {
        var command = new CreateAccountCommand(request.Name, request.Type.ToString());

        var CreateAccountResult = await _mediator.Send(command);

        return CreateAccountResult.Match(
            accountId => Ok(new AccountResponse(accountId, request.Name, request.Type)), 
            error => Problem());
    }
}