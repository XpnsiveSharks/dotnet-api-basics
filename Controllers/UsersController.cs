using dotnet_api.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly AuditLogService _audit;

    public UsersController(AuditLogService audit)
    {
        _audit = audit;
    }

    [HttpPost]
    public IActionResult CreateUser()
    {
        _audit.Log("CREATE", "User", "admin-1");

        return Ok("user created");
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_audit.GetAll());
    }
    [HttpGet("user/{id}")]
    public IActionResult GetByUser(string userId)
    {
        return Ok(_audit.GetByUser(userId));
    }
}
