using System.Net;
using System.Text.Json;

namespace APEC.ProyectoFinal.API
{
    public class TrackingMiddleware
    {
        private readonly RequestDelegate _next;

        private readonly IConfiguration _configuration;

        public TrackingMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
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
            ApiError apiError;

            switch (exception)
            {
                case ApiException:
                    {
                        //Handled exceptions throwed by code
                        var ex = exception as ApiException;

                        apiError = new ApiError(ex.Message)
                        {
                            Errors = ex.Errors,
                        };
#if DEBUG
                        apiError.Detail = ex.StackTrace;
#endif

                        context.Response.StatusCode = (int)ex.StatusCode;
                        break;
                    }

                default:
                    {
                        // Unhandled errors
#if !DEBUG
                        var msg = _configuration.GetValue<string>("Messages:Error:Error500");
                        string stack = null;
#else
                        var msg = exception.GetBaseException().Message;

                        string stack = exception.StackTrace;
#endif
                        apiError = new ApiError(msg)
                        {
                            Detail = stack,
                            Message = exception.Message
                        };
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                    }
            }

            // always return a JSON result
            var result = JsonSerializer.Serialize(apiError);

            context.Response.ContentType = "application/json";

            return context.Response.WriteAsync(result);
        }
    }
}