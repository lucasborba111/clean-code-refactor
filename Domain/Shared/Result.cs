namespace clean_code_refactor.Domain.Shared
{
    public class Result
    {
        protected internal Result(bool isSuccess, List<Error> errors)
        {
            if (isSuccess && errors.Any())
            {
                throw new InvalidOperationException();
            }

            if (!isSuccess && !errors.Any())
            {
                throw new InvalidOperationException();
            }

            IsSuccess = isSuccess;
            Errors = errors;
        }

        public bool IsSuccess { get; }

        public bool IsFailure => !IsSuccess;

        public List<Error> Errors { get; }

        public static Result Success() => new(true, new List<Error>());

        public static Result<TValue> Success<TValue>(TValue value) => new(value, true, new List<Error>());

        public static Result Failure(List<Error> errors) => new(false, errors);

        public static Result<TValue> Failure<TValue>(List<Error> errors) => new(default, false, errors);

        public static Result<TValue> Create<TValue>(TValue? value, string field) =>
            value is not null ? Success(value) : Failure<TValue>(new List<Error> { Error.NullValue(field) });
    }
}
