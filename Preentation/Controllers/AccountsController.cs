using Microsoft.AspNetCore.Mvc;
using Preentation.Services;

namespace Preentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountsController(IAccountService accountService) : ControllerBase
{
    private readonly IAccountService _accountService = accountService;
}
