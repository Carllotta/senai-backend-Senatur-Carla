using System;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? FkTipoUsuario { get; set; }

        public TiposUsuarios FkTipoUsuarioNavigation { get; set; }
    }
}
