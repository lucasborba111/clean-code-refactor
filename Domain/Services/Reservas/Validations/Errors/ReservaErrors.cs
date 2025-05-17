using clean_code_refactor.Domain.Bases;

namespace clean_code_refactor.Domain.Services.Reservas.Validations.Errors
{
    public class ReservaErrors
    {
        public static Error QuantidadePessoasError(string field) => new("Error.InvalidPeople", $"A {field} deve ser entre 1 e 4.");
        public static Error DiariasError(string field) => new("Error.InvalidDiarias", $"O {field} deve ser maior que zero.");
        public static Error TipoQuartoError(string field) => new("Error.InvalidTipoQuarto", $"O {field} deve ser 1, 2 ou 3.");
    }
}
