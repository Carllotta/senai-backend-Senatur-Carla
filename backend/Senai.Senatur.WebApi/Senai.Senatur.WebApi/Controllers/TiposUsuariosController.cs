using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Controllers
{
    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato domínio/api/NomeController
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]
    public class TiposUsuariosController : ControllerBase
    {
        private ITiposUsuariosRepository _tiposUsuariosRepository;

        public TiposUsuariosController()
        {
            _tiposUsuariosRepository = new TiposUsuariosRepository();
        }
        
    }
}
