using Common.Models.Responses;

namespace Common.Extensions
{
    public static class ExceptionExtensions
    {
        public static ApiResponse<string> AsApiResponse(this Exception exception)
        {
            var response = new ApiResponse<string>()
            {
                FailureMessage = "Failed to validate request",
                Errors = new List<ApiError>() {
                    new ApiError(){
                        StackTrace = exception.StackTrace,
                        Message = exception.Message
                    }
                },
                Success = false,
                Data = null
            };
            return response;
        }
    }
}
