using System.ComponentModel.DataAnnotations;

namespace GrupoLi.Models
{
    public class Email
    {
        [Required]
        public string Nombre { get; set; }

        [Required, EmailAddress]
        public string FromEmail { get; set; }

        [Required]
        public string Asunto { get; set; }

        [Required]
        public string Mensaje { get; set; }
    }
}