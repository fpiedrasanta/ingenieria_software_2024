using Microsoft.AspNetCore.Mvc;
using web_api.dto.common;
using web_api.dto.login;

namespace web_api.Controllers;


[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    private readonly ILogger<LoginController> _logger;
    
    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "Login")]
    public IActionResult Post(LoginRequestDTO loginRequestDTO)
    {
        if(loginRequestDTO != null &&
           loginRequestDTO.mail.ToLower().Equals("fede.piedrasanta@gmail.com") &&
           loginRequestDTO.password == "TEST1234")
        {
            return Ok(new LoginResponseDTO 
            {
                success = true,
                message = "",
                id = 1,
                name = "Federico",
                surname = "Piedrasanta",
                description = "Biólogo - Conicet",
                urlAvatar = "https://placedog.net/500",
                mail = "fede.piedrasanta@gmail.com"
            });
        }
        else 
        {
            return Unauthorized(new ErrorResponseDTO
            {
                success = false,
                message = "Invalid mail or password"
            });
        }
    }
}