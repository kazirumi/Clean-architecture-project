using Microsoft.AspNetCore.Mvc;
using Project.Contracts.Accounts;

namespace Project.Api.Controllers;

[ApiController]
[Route("accounts")]
public class AccountsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateAccount(CreateAccountRequest request)
    {
        return Ok(request);
    }
}