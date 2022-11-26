using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploUm.Models
{
    public class Usuario
    {
        [Display(Name = "Nome do Usuário")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Idade do Usuário")]
        [Range(18, 70, ErrorMessage = "Idade permitida entre 18 e 70")]
        public string Idade { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public string DataNasc { get; set; }

        [Display(Name = "Email profissional")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Display(Name = "Crie seu login")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login obrigatório")]
        public string Login { get; set; }

        [Display(Name = "Crie sua senha")]
        [Required(ErrorMessage = "Senha obrigatória")]
        public string Senha { get; set; }

        [Display(Name = "Confirme sua senha")]
        [System.ComponentModel.DataAnnotations.Compare("Senha" , ErrorMessage = "A senha não corresponde")]
        public string ConfSenha { get; set; }

        [Display(Name = "Escolha sua Casa")]
        [Required(ErrorMessage = "A Casa é obrigatório")]
        public string Casa { get; set; }

        [Display(Name = "Digite seu filme fevorito")]
        [Required(ErrorMessage = "O filme é obrigatório")]
        public string Filme { get; set; }

        [Display(Name = "Digite seu Livro favorito")]
        [Required(ErrorMessage = "O Livro é Obrigatório")]
        public string Livro { get; set; }


        [Display(Name = "Digite seu Personagem Favorito")]
        [Required(ErrorMessage = "O Personagem é Obrigatório")]
        public string Personagem { get; set; }

        [Display(Name = "Escolha seu pet")]
        [Required(ErrorMessage = "O Pet é obrigatório")]
        public string Pet { get; set; }

        [Display(Name = "Escolha Feitiço")]
        [Required(ErrorMessage = "O Feitiço é obrigatório")]
        public string Feitico { get; set; }



    }
}