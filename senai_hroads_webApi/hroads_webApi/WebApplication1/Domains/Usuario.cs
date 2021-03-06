using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class Usuario
    {
        public int? IdTipoUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
