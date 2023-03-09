namespace APEC.ProyectoFinal.API
{
    public class ApiError
    {
        public string Message { get; set; }

        public bool IsApiError { get; private set; }

        public string Detail { get; set; }

        public object Errors { get; set; }

        public ApiError(string message)
        {
            Message = message;
            IsApiError = true;
        }
    }
}