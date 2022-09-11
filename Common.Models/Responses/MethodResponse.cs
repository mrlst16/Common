namespace Common.Models.Responses
{
    public class MethodResponse<T> : MethodResponse, IResponse<T>
    {
        public T Data { get; set; }

        public static implicit operator bool(MethodResponse<T> response) => response.Success;
        public static implicit operator T(MethodResponse<T> response) => response.Data;

        public new MethodResponse<T> AddError(string errorMessage)
        {
            Errors.Add(new ApiError()
            {
                Message = errorMessage
            });
            return this;
        }

        public new MethodResponse<T> AddError(string errorMessage, string errorCode)
        {
            Errors.Add(new ApiError()
            {
                Message = errorMessage,
                ErrorCode = errorCode
            });
            return this;
        }

        public new MethodResponse<T> AddError(string errorMessage, string errorCode, string stackTrace)
        {
            Errors.Add(new ApiError()
            {
                Message = errorMessage,
                ErrorCode = errorCode,
                StackTrace = stackTrace
            });
            return this;
        }

        public new MethodResponse<T> AddError(Exception e, string errorCode)
        {
            Errors.Add(new ApiError()
            {
                Message = e.Message,
                ErrorCode = errorCode,
                StackTrace = e.StackTrace
            });
            return this;
        }

        public new MethodResponse<T> AsSucces()
        {
            this.Success = true;
            return this;
        }

        public new MethodResponse<T> AsFailure()
        {
            this.Success = false;
            return this;
        }
    }

    public class MethodResponse : IResponse
    {

        public bool Success { get; set; }
        public IList<ApiError> Errors { get; set; } = new List<ApiError>();

        public static implicit operator bool(MethodResponse response) => response.Success;

        public MethodResponse AddError(string errorMessage)
        {
            Errors.Add(new ApiError()
            {
                Message = errorMessage
            });
            return this;
        }

        public MethodResponse AddError(string errorMessage, string errorCode)
        {
            Errors.Add(new ApiError()
            {
                Message = errorMessage,
                ErrorCode = errorCode
            });
            return this;
        }

        public MethodResponse AddError(string errorMessage, string errorCode, string stackTrace)
        {
            Errors.Add(new ApiError()
            {
                Message = errorMessage,
                ErrorCode = errorCode,
                StackTrace = stackTrace
            });
            return this;
        }

        public MethodResponse AddError(Exception e, string errorCode)
        {
            Errors.Add(new ApiError()
            {
                Message = e.Message,
                ErrorCode = errorCode,
                StackTrace = e.StackTrace
            });
            return this;
        }

        public MethodResponse AsSucces()
        {
            this.Success = true;
            return this;
        }

        public MethodResponse AsFailure()
        {
            this.Success = false;
            return this;
        }
    }
}
