using System;
using System.Collections.Generic;

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
        //Devo inserir required nessa sessão?? 
        public string Titulo { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
