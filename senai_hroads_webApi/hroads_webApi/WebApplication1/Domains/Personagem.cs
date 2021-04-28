﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class Personagem
    {
        public int IdPersonagem { get; set; }
        public string NomePersonagem { get; set; }
        public int? IdClasse { get; set; }
        public string VidaMáxima { get; set; }
        public string ManaMáxima { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataCriacao { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
    }
}
