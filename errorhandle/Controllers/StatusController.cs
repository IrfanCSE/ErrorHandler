using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace errorhandle.Controllers;

[ApiController]
[Route("[controller]")]
public class StatusController : ObjectResultInherit
{
    public StatusController()
    {
    }

    [HttpGet]
    [Route("Throw_Exception")]
    public async Task<IActionResult> Throw_Exception()
    {
        throw new Exception("Throw_Exception");
    }
    [HttpGet]
    [Route("Return_Ok")]
    public async Task<IActionResult> Return_Ok()
    {
        return Ok(new ApiResponse<string>(HttpStatusCode.OK, "Return_Ok"));
    }

    [HttpGet]
    [Route("Dynamic_Status")]
    public async Task<IActionResult> Dynamic_Status(HttpStatusCode status)
    {
        var data = new ApiResponse<object>
        {
            StatusCode = status,
            Message = "Dynamic_Status",
            Data = new List<object>{
                new {
                    Name = "One",
                    Value = 1
                },
                new {
                    Name = "Two",
                    Value = 2
                },
                new {
                    Name = "Three",
                    Value = 3
                }
            }
        };
        return Go(data);
    }
}
