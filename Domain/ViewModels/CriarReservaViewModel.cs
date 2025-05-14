using clean_code_refactor.Domain.Models;

namespace clean_code_refactor.Domain.ViewModels
{
    public class CriarReservaViewModel
    {
        public int QuantidadePessoas { get; set; }
        public int Diarias { get; set; }
        public TipoQuartoEnum TipoQuarto { get; set; }
    }
}
