﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class TipoHabilidade
    {
        public TipoHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public int IdTipoHabilidade { get; set; }
        public string TipoHabilidade1 { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
