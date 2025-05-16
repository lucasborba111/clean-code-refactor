using clean_code_refactor.Domain.Shared;

namespace clean_code_refactor.Domain.Errors
{
    public class ClienteErrors
    {
        public static Error NullValueError(string field) => new("Error.NullValue", $"O {field} não pode ser nulo!");
    }
}
