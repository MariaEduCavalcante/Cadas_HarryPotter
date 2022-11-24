using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace ProjetoWeb_LM.Models
{
    public class Usuario
    {
        [Display(Name = "Usuário")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomeUsuario { get; set; }

        [Required]
        [Display(Name = "Data de nascimento")]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]|(?:Jan|Mar|May|Jul|Aug|Oct|Dec)))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2]|(?:Jan|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec))\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)(?:0?2|(?:Feb))\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9]|(?:Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep))|(?:1[0-2]|(?:Oct|Nov|Dec)))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$", ErrorMessage = "Formato de data inválido. Utilize barras.")]
        public string Nascimento { get; set; }

        [Display(Name = "Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        [Display(Name = "Login")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente Letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login obrigatório")]
        //[Remote("LoginUnico", "usuario", ErrorMessage = "Login já cadastrado")]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Senha obrigatória")]
        public string Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não corresponde")]
        public string Confsenha { get; set; }

        [Display(Name = "Qual seu livro preferido?")]
        [StringLength(70, MinimumLength = 11, ErrorMessage = "Insira de 11 a 70 caracteres")]
        public string Livro { get; set; }

        [Display(Name = "Qual seu filme preferido?")]
        [StringLength(70, MinimumLength = 11, ErrorMessage = "Insira de 11 a 70 caracteres")]
        public string Filme { get; set; }

        [Display(Name = "Escolha sua casa")]
        [Required (ErrorMessage = "Escolha uma casa")]
        public string Casa { get; set; }

        [Display(Name = "Qual seu pet preferido?")]
        [Required(ErrorMessage = "Escolha um pet")]
        public string Pet { get; set; }


    
    }
}