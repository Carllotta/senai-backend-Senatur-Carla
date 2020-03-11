using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacotesRepository : IPacotesRepository
    {
        SenaturContext ctx = new SenaturContext();


        public void AtualizarPacote(int id, Pacotes atualizaPacote)
        {
            Pacotes pascotesBuscar = ctx.Pacotes.Find(id);

            pascotesBuscar.NomePacote = atualizaPacote.NomePacote;
            pascotesBuscar.Descricao = atualizaPacote.Descricao;
            pascotesBuscar.DataVolta = atualizaPacote.DataVolta;
            pascotesBuscar.DataIda = atualizaPacote.DataIda;
            pascotesBuscar.Valor = atualizaPacote.Valor;
            pascotesBuscar.Ativo = atualizaPacote.Ativo;
            pascotesBuscar.NomeCidade = atualizaPacote.NomeCidade;

             ctx.Pacotes.Update(pascotesBuscar);

             ctx.SaveChanges();
        }

        public Pacotes BuscarPacotePorId(int id)
        {

            return ctx.Pacotes.FirstOrDefault(p => p.IdPacote == id);

        }

        public void CadastrarPacote(Pacotes novoPacote)
        {
            ctx.Pacotes.Add(novoPacote);

            ctx.SaveChanges();
        }

        public void DeletarPacote(int id)
        {
            Pacotes pascotesBuscar = ctx.Pacotes.Find(id);
            ctx.Pacotes.Remove(pascotesBuscar);


            ctx.SaveChanges();
        }

        public List<Pacotes> Listar()
        {
           return ctx.Pacotes.ToList();
        }

        public List<Pacotes> ListarAtivos(bool ativo)
        {
            return ctx.Pacotes.ToList().FindAll(p => p.Ativo == ativo);
        }

    }
}
