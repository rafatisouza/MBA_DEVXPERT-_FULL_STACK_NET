using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string ?Descricao { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "O campo {0} deve ser maior que zero.")]
        public Guid VendedorId { get; set; }
        public decimal Preco { get; set; }
   
     

       
    }
}
