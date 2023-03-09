using System.Net;

namespace APEC.ProyectoFinal.API
{
    [Serializable]
    public class ApiException : Exception
    {
        private const string DEFAULT_MESSAGE_WITH_ERRORS = "Una o más validaciones han fallado. Favor ver el detalle del error.";
        //private const string DEFAULT_MESSAGE_WITH_ERRORS = "Una o más validaciones han fallado. Favor ver el detalle del error.";

        public HttpStatusCode StatusCode { get; }

        public object Errors { get; set; }

        public ApiException(string message = DEFAULT_MESSAGE_WITH_ERRORS,
                            HttpStatusCode statusCode = HttpStatusCode.InternalServerError,
                            object errors = null) :
            base(message)
        {
            StatusCode = statusCode;
            Errors = errors;
        }

        public ApiException(Exception ex, HttpStatusCode statusCode = HttpStatusCode.InternalServerError) : base(ex.Message)
        {
            StatusCode = statusCode;
        }

        public ApiException(Exception ex, string message = DEFAULT_MESSAGE_WITH_ERRORS,
                            HttpStatusCode statusCode = HttpStatusCode.InternalServerError) : base(message, ex)
        {
            StatusCode = statusCode;
        }
    }
}