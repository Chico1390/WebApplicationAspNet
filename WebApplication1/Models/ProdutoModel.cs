using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Web;

namespace WebApplication1.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Precisa do nome do produto.")]
        [StringLength(60, MinimumLength = 3)]
        public string Nome { get; set; }

        [Display(Name = "Preco")]
        [DataType(DataType.Currency)]
        public Decimal Preco { get; set; }

        public string Descrição { get; set; }

        [Display(Name = "Atualizado em")]
        [DataType(DataType.Date)]
        public DateTime UltimaAtualizacao { get; set; }

        public int IdCategoria { get; set; }
        public virtual CategoriaModel Categoria { get; set; }

    }
}
