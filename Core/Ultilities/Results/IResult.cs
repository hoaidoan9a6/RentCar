namespace Core.Ultilities.Results
{
    public interface IResult
    {
        bool Success { get; }

        string Message { get;  }

    }
}