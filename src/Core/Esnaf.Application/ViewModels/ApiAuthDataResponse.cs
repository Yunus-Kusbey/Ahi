namespace Esnaf.Application.ViewModels
{
    public class ApiAuthDataResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
