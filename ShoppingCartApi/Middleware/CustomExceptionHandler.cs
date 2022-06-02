using Application.Common.Exceptions;
using FluentValidation;
using System.Net;

namespace ShoppingCartApi.Middleware
{
    public class CustomExceptionHandler
    {
        private readonly RequestDelegate _next;

        public CustomExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {

            HttpStatusCode code = HttpStatusCode.InternalServerError;

            string? result = string.Empty;

            switch (exception)
            {
                case ValidationException _:
                    code = HttpStatusCode.BadRequest;
                    break;

                case NotFoundException _:
                    code = HttpStatusCode.NotFound;
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            if (result == string.Empty) result = exception.Message;

            ErrorResponse? errorResponse = new ErrorResponse
            {
                ErrorCode = context.Response.StatusCode,
                ErrorMessage = result
            };

            return context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(errorResponse));
        }
    }

    public class ErrorResponse
    {
        public int ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
    }

}
