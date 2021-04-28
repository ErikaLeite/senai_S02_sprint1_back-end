using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class ClasseHabilidade
    {
        public int IdClasseHabilidade { get; set; }
        public int? IdHabilidade { get; set; }
        public int? IdClasse { get; set; }
        //? quer dizer que o campo pode ser NULL

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
