using Microsoft.AspNetCore.Mvc;

[ApiController]             // marks this as a controller
[Route("api/[controller]")] // base route: api/users (http://localhost:5287/Users)

public class UsersController : ControllerBase{
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = new []
        {
            new Person("Menen", 28),
            new Person("Sharkie", 19)
        };
        return Ok(users);
    }
}