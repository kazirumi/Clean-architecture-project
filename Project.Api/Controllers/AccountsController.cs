using Ardalis.SmartEnum;
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
    private readonly ISender _mediator;

    public AccountsController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAccount(CreateAccountRequest request)
    {
        if (!Domain.Accounts.AccountType.TryFromName(request.Type.ToString(), out var accountType))
        {
            return Problem(statusCode: StatusCodes.Status400BadRequest, title: "Invalid account type", detail: "Account type must be one of the following: Asset, Liability, Equity, Revenue, Expense");
        }
        var command = new CreateAccountCommand(request.Name, accountType);

        var createAccountResult = await _mediator.Send(command);

        return createAccountResult.Match(
            account => Ok(new AccountResponse(account.Id, request.Name, request.Type)), 
            error => Problem());
    }
    
    [HttpGet]
    [Route("{accountId:int}")]
    public async Task<IActionResult> GetAccount(int accountId)
    {
        var command = new GetAccountQuery(accountId);

        var getAccountResult = await _mediator.Send(command);

        return getAccountResult.Match(
            account => Ok(new AccountResponse(account.Id, account.Name, Enum.Parse<AccountType>(account.Type.Name))), 
            error => Problem());
    }
}