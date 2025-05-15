using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Email { get; set; }
    }
}
