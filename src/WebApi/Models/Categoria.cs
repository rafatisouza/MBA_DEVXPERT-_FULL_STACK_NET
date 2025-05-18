using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string? Descricao { get; set; }

    }
}
