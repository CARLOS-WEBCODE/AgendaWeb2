using System.ComponentModel.DataAnnotations;

namespace AgendaWeb.Presentation.Models
{
    public class EventoConsultaViewModel
    {
        [Required(ErrorMessage = "Por favor, informe a data de início.")]
        public string? DataMin { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de término.")]
        public string? DataMax { get; set; }

        [Required(ErrorMessage = "Por favor, marque Ativo ou Inativo.")]
        public int? Ativo { get; set; }
    }
}
