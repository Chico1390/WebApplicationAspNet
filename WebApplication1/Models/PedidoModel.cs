using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    [Bind(Include = "Id")]
    public class PedidoModel
    {

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Precisa de primeiro nome")]
        [DisplayName("Primeiro Nome")]
        [StringLength(160)]
        public string PrimeiroNome { get; set; }
        [Required(ErrorMessage = "Precisa de sobrenome")]
        [DisplayName("Sobrenome")]
        [StringLength(160)]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Precisa de endereço")]
        [StringLength(70)]
        public string Enderesso { get; set; }
        [Required(ErrorMessage = "Precisa de cidade")]
        [StringLength(40)]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Precisa de estado")]
        [StringLength(40)]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Precisa de código postal")]
        [DisplayName("Codigo Postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Required(ErrorMessage = "Precisa de país")]
        [StringLength(40)]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Precisa de numero de telefone")]
        [StringLength(24)]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Precisa de email")]
        [DisplayName("Email")]

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email não é valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "datetime2")]
        public DateTime DataCriada { get; set; }

        [ScaffoldColumn(false)]
        public Decimal Quantidade { get; set; }

        [ScaffoldColumn(false)]
        public string ClienteUserName { get; set; }
    }
}
