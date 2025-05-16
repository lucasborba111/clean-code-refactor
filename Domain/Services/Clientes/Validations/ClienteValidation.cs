using clean_code_refactor.Domain.Models;
using clean_code_refactor.Domain.Shared;

namespace clean_code_refactor.Domain.Services.Clientes.Validations
{
    public class ClienteValidation
    {
        public List<Error> CreatingValidation(Cliente dto)
        {
            var errors = new List<Error>();

            if (string.IsNullOrEmpty(dto.Nome))
                errors.Add(Error.NullValue("Nome"));

            if (string.IsNullOrEmpty(dto.Cpf))
                errors.Add(Error.NullValue("Cpf"));

            return errors;
        }
    }
}
