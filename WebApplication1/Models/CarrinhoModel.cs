using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CarrinhoModel
    {
        [Key]
        public int Id { get; set; }
        public string IdCarrinho { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DataCriada { get; set; }
        public virtual ProdutoModel Produto { get; set; }
    }
}
