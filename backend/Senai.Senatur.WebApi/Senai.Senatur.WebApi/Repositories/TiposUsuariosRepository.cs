using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class TiposUsuariosRepository : ITiposUsuariossRepository
    {
        SenaturContext ctx = new SenaturContext();

        public TiposUsuarios BuscarPorId(int id)
        {
            return ctx.TiposUsuarios.FirstOrDefault(t => t.IdTipoUsuario == id);
        }

        public List<TiposUsuarios> ListarTipos()
        {
            return ctx.TiposUsuarios.ToList();
        }
    }
}
    