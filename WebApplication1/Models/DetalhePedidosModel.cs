using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DetalhePedidosModel
    {
        [Key]
        [Column(Order = 0)]
        public int ProdutoId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int PedidoId { get; set; }

        public int Quantidade { get; set; }

        public virtual ProdutoModel Produto { get; set; }
        public virtual PedidoModel Pedido { get; set; }
    }
}
