using System.ComponentModel.DataAnnotations;

namespace clean_code_refactor.ViewModels
{
    public class CriarClienteViewModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
    }
}
