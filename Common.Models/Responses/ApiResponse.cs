namespace Common.Models.Responses
{

    public class ApiResponse<T> : IResponse<T>
    {
        public T Data { get; set; }

        public bool Success { get; set; } = true;

        public IList<ApiError> Errors { get; set; }

        public string? FailureMessage { protected get; set; }
        public string? SuccessMessage { protected get; set; }

        private string _message = null;
        public string Message
        {
            get
            {
                if (_message != null)
                    return _message;

                return Success ? SuccessMessage : FailureMessage;
            }
        }
    }
}
