using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ClienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }

    }
    public class LogInModel
    {
        [Required]
        [Display(Name = "Nome de Usuario")]
        public string NomeDeUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Lembre minha senha?")]
        public bool Lembrar { get; set; }
    }

    public class RegistrarModel
    {
        [Required]
        [Display(Name = "Nome de Usuario")]
        public string NomeDeUsuario { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Endereço de email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} precisa de pelo menos {2} caracteres de comprimento.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Comfirmar senha")]
        [Compare("Senha", ErrorMessage = "As senhas não batem.")]
        public string ComfirmarSenha { get; set; }
    }

    public class MudarSenhaPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha atual")]
        public string SenhaVelha { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} precisa de pelo menos {2} caracteres de comprimento.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha nova")]
        public string SenhaNova { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nova senha")]
        [Compare("SenhaNova", ErrorMessage = "As senhas não batem.")]
        public string ComfirmarSenha { get; set; }
    }

}
