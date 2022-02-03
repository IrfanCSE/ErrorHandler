using System.Net;
using Microsoft.AspNetCore.Mvc;

public class ObjectResultInherit : ControllerBase
{
    public ObjectResult Go<T>(ApiResponse<T> response)
    {
        switch (response.StatusCode)
        {
            case HttpStatusCode.OK:
                return Ok(response);
            case HttpStatusCode.BadRequest:
                return BadRequest(response);
            case HttpStatusCode.Created:
                return CreatedAtAction(string.Empty, response);
            case HttpStatusCode.Unauthorized:
                return Unauthorized(response);
            case HttpStatusCode.InternalServerError:
                return StatusCode((int)response.StatusCode, response);
            default:
                return StatusCode((int)response.StatusCode, response);
        }
    }
}