namespace AgendaWeb.Presentation.Models
{
    /// <summary>
    /// Classe de modelo de dados para a página de cadastro de eventos
    /// </summary>
    public class EventoCadastoViewModel
    {
        public string? Nome { get; set; }
        public string? Data { get; set; }
        public string? Hora { get; set; }
        public string? Descricao { get; set; }
        public string? Prioridade { get; set; }
    }
}
