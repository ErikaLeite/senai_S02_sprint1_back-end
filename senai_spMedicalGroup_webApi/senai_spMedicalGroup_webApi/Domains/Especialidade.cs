using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_spMedicalGroup_webApi.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdEspecialidade { get; set; }

        //[Required(ErrorMessage ="Insira um nome para a Especialidade")]  - devo inserir ???? 
        public string Titulo { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
