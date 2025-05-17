using clean_code_refactor.Domain.Bases;
using clean_code_refactor.Domain.Services.Clientes.Validations.Errors;
using clean_code_refactor.Domain.ViewModels;
using System.Text.RegularExpressions;

namespace clean_code_refactor.Domain.Services.Clientes.Validations
{
    public class ClienteValidation : Validation<CriarClienteViewModel>
    {
        public override List<Error> CreatingValidation(CriarClienteViewModel dto)
        {
            var errors = new List<Error>();

            if (string.IsNullOrEmpty(dto.Nome))
                errors.Add(Error.NullValue("Nome"));

            if (!Regex.IsMatch(dto.Cpf, @"^\d{11}$"))
                errors.Add(ClienteErrors.CpfError("Cpf"));


            return errors;
        }
    }
}
