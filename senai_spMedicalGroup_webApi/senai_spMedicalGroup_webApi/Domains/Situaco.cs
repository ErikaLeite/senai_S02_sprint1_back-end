using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_spMedicalGroup_webApi.Domains
{
    public partial class Situaco
    {
        public Situaco()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdSituacao { get; set; }
        [Required(ErrorMessage = "Atualize o status")]
        public string Titulo { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
