using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_spMedicalGroup_webApi.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdMedico { get; set; }
        public int IdUsuario { get; set; }
        public int IdClinica { get; set; }
        public int IdEspecialidade { get; set; }

        [Required(ErrorMessage = "Informe o nome do médico")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o CRM")]
        public string Crm { get; set; }
        [Required(ErrorMessage = "Informe o estado onde o médico atua")]
        public string Estado { get; set; }

        public virtual Clinica IdClinicaNavigation { get; set; }
        public virtual Especialidade IdEspecialidadeNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
