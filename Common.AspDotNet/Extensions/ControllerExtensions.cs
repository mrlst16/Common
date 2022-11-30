using Common.Models.Responses;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Common.AspDotNet.Extensions
{
    public static class ControllerExtensions
    {
        public static OkObjectResult Call<TRequest, TResponse>(
            TRequest request,
            IValidator<TRequest> _validator,
            Func<TRequest, TResponse> function,
            string successMessage = "Successfully processed request."
        )
        {

            return new OkObjectResult(new ApiResponse<TResponse>()
            {
                Data = function(request),
                SuccessMessage = successMessage,
                Success = false
            });
        }

    }
}
