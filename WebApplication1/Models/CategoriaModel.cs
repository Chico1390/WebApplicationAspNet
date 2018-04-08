using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WebApplication1.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Nome de categoria é necessario.")]
        [MaxLength(45, ErrorMessage = "Nome só pode ter 45 letras.")]
        public string Nome { get; set; }

        public virtual ICollection<ProdutoModel> Produtos { get; set; }
    }
}
