namespace Common.Models.Responses
{
    public interface IResponse<T> : IResponse
    {
        T Data { get; }
    }

    public interface IResponse
    {
        bool Sucess { get; }
        IList<ApiError> Errors { get; set; }
    }
}
