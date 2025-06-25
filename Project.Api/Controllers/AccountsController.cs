using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Accounts.Commands.CreateAccount;
using Project.Application.Accounts.Queries.GetAccount;
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

        var createAccountResult = await _mediator.Send(command);

        return createAccountResult.Match(
            account => Ok(new AccountResponse(account.Id, request.Name, request.Type)), 
            error => Problem());
    }
    
    [HttpGet]
    [Route("{accountId:int}")]
    public async Task<IActionResult> CreateAccount(int accountId)
    {
        var command = new GetAccountQuery(accountId);

        var getAccountResult = await _mediator.Send(command);

        return getAccountResult.Match(
            account => Ok(new AccountResponse(account.Id, account.Name, Enum.Parse<AccountType>(account.Type))), 
            error => Problem());
    }
}