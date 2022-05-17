namespace SmartTrade.Models
{
    public class ApiResult<T>
    {
        public bool Success { get; set; }

        public T Data { get; set; }

        public string[] Errors { get; set; }
    }
}
