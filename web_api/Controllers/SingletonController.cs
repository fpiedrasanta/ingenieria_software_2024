using Microsoft.AspNetCore.Mvc;
using web_api.dto.common;
using web_api.dto.login;
using web_api.helpers;
using web_api.mock;

namespace web_api.Controllers;


[ApiController]
[Route("[controller]")]
public class SingletonController : ControllerBase
{
    private readonly ILogger<SingletonController> _logger;
    
    public SingletonController(ILogger<SingletonController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetNextNumber")]
    public IActionResult Get()
    {
        VisitCounter? visitCounter = VisitCounter.GetInstance();

        long nextNumber = visitCounter == null ? 0 : visitCounter.GetNextNumber();
        return Ok(new 
        {
            numero = nextNumber
        });
    }
}