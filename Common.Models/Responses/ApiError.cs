namespace Common.Models.Responses
{
    public record ApiError
    {
        public string? Message { get; set; }
        public string? ErrorCode { get; set; }
        public string? StackTrace { get; set; }
    }
}
