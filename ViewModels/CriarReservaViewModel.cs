using clean_code_refactor.Models;

namespace clean_code_refactor.ViewModels
{
    public class CriarReservaViewModel
    {
        public int QuantidadePessoas { get; set; }
        public int Diarias { get; set; }
        public TipoQuartoEnum TipoQuarto { get; set; }
    }
}
