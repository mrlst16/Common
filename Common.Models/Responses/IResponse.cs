namespace Common.Models.Responses
{
    public interface IResponse<T> : IResponse
    {
        T Data { get; }
    }

    public interface IResponse
    {
        bool Success { get; }
        IList<ApiError> Errors { get; set; }
    }
}
