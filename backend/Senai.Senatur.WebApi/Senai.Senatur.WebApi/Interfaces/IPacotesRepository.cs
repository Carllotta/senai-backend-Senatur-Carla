using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacotesRepository
    {
        
        List<Pacotes> Listar();

        Pacotes BuscarPacotePorId(int id);
              
        void CadastrarPacote(Pacotes novoPacote);

        void AtualizarPacote(int id, Pacotes atualizaPacote);

        void DeletarPacote(int id);

        List<Pacotes> ListarAtivos(bool ativo);

        List<Pacotes> ListarPorCidade(string cidade);

        //List<Pacotes> ListaOrdenada(string ordenacao);

    }
}
