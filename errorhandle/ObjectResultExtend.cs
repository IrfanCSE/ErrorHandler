// using System.Net;
// using Microsoft.AspNetCore.Mvc;

// public static class ObjectResultExtend
// {
//     public static ObjectResult Go<T>(this ControllerBase controller,ApiResponse<T> response)
//     {
//         switch (response.StatusCode)
//         {
//             case HttpStatusCode.OK:
//                 return controller.Ok(response);
//             case HttpStatusCode.BadRequest:
//                 return controller.BadRequest(response);
//             case HttpStatusCode.Created:
//                 return controller.CreatedAtAction("Get", new { id = 1 }, response);
//             case HttpStatusCode.Unauthorized:
//                 return controller.Unauthorized(response);
//             case HttpStatusCode.InternalServerError:
//                 return controller.StatusCode((int)response.StatusCode, response);
//             default:
//                 return controller.StatusCode((int)response.StatusCode, response);
//         }
//     }    
// }