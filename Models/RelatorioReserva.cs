namespace clean_code_refactor.Models
{
    public class RelatorioReserva
    {
        public string Status { get; set; }
        public List<Reserva> Reservas { get; set; }
        public decimal TotalRecebido { get; set; }
    }
}
