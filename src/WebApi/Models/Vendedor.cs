using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Vendedor
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string ?Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string ?Email { get; set; }
    }
}
