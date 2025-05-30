namespace dotnet_rpg.Models
{
    #region Properties ServiceResponse
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;
    }
    #endregion
}