using Senai.Senatur.WebApi.Controllers;
using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IUsuariosRepository
    {
        
        List<Usuarios> Listar();
                
        Usuarios BuscarUsuarioPorId(int id);

        Usuarios BuscarPorEmailSenha(string email, string senha);

    }
}
