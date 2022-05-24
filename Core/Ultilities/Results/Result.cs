namespace Core.Ultilities.Results
{
    public class Result : IResult
    {

        // this ile diğer constructor'ı da çalıştırdık.
        public Result (bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        // get => Read Only
        // Read Only olduğunda Constructor ile set edilebilir. 
        public bool Success { get; }

        public string Message { get; }
    }


}