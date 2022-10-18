using Common.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Common.AspDotNet.Extensions
{
    public static class ControllerExtensions
    {
        public static OkObjectResult CallWithoutTryCatch<TRequest, TResponse>(
            TRequest request,
            Func<TRequest, TResponse> function,
            string successMessage
        )
            => new OkObjectResult(new ApiResponse<TResponse>()
            {
                Data = function(request),
                SuccessMessage = successMessage,
                Success = false
            });
    }
}
