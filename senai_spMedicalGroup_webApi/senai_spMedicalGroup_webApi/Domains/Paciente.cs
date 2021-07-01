using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_spMedicalGroup_webApi.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdPaciente { get; set; }
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Informe o nome do paciente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe a data de nascimento")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Informe o telefone")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe o RG")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "Informe o CPF")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Informe o CEP")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Informe o endereço")]
        public string Endereco { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
