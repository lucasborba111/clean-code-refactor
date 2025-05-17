using clean_code_refactor.Domain.Bases;
using clean_code_refactor.Domain.Services.Reservas.Validations.Errors;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Services.Reservas.Validations
{
    public class ReservaValidation : Validation<CriarReservaViewModel>
    {
        public override List<Error> CreatingValidation(CriarReservaViewModel dto)
        {
            var errors = new List<Error>();

            if (dto.QuantidadePessoas < 1 || dto.QuantidadePessoas > 4)
                errors.Add(ReservaErrors.QuantidadePessoasError("Quantidade de pessoas inválida: deve ser entre 1 e 4."));

            if (dto.Diarias < 1)
                errors.Add(ReservaErrors.DiariasError("Número de diárias inválido: deve ser maior que zero."));

            //if (dto.TipoQuarto < 1 || dto.TipoQuarto > 3)
            //    errors.Add(Error.InvalidValue("Tipo de quarto inválido: deve ser 1 (Standard), 2 (Deluxe) ou 3 (Premium)."));


            return errors;
        }
    }
}
