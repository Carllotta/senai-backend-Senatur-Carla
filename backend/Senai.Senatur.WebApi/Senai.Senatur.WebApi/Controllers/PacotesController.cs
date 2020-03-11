using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class PacotesController : ControllerBase
    {
        private IPacotesRepository _pacotesRepository;

        public PacotesController()
        {
            _pacotesRepository = new PacotesRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pacotesRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById (int id)
        {
            return Ok(_pacotesRepository.BuscarPacotePorId(id));
        }

        [HttpPost]
        public IActionResult Post (Pacotes novoPacote)
        {
            _pacotesRepository.CadastrarPacote(novoPacote);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Pacotes atualizaPacote)
        {
            
            _pacotesRepository.AtualizarPacote(id, atualizaPacote);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pacotesRepository.DeletarPacote(id);

                 return StatusCode(204);
        }

        [HttpGet("buscarativos/{ativo}")]
        public IActionResult GetAtivos(bool ativo)
        {
            return Ok(_pacotesRepository.ListarAtivos(ativo));
        }

        [HttpGet("buscarcidade/{cidade}")]
        public IActionResult GetPorCidade(string cidade)
        {
            return Ok(_pacotesRepository.ListarPorCidade(cidade));
        }
        
        //[HttpGet()]
        //public IActionResult GetPacotes()
        //{
        //    return Ok(_pacotesRepository.Listar());
        //}


        //////[HttpGet("{id}")]
        //////public IActionResult Get(int id)
        //////{
        //////    return Ok(_pacotesRepository.BuscarPacotePorId(id));
        //////}

        //////[HttpGet("{ativo}")]
        //////public IActionResult GetAtivos(bool ativo)
        //////{
        //////    return Ok(_pacotesRepository.ListarAtivos(ativo));
        //////}

    }
}
