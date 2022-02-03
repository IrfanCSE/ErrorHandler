using System.Net;

public class ApiResponse<T>
{
    public ApiResponse(){}
    public ApiResponse(HttpStatusCode statusCode, string? message = null, T? data = default)
    {
        StatusCode = statusCode;
        Message = message;
        Data = data;
    }
    public HttpStatusCode StatusCode { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
}