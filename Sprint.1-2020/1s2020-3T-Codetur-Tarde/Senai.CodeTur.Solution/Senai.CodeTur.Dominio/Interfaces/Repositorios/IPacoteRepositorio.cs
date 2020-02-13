using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorios
{
    public interface IPacoteRepositorio
    {
        List<PacoteDominio> Listar();

        PacoteDominio BuscarPorId(int id);

        PacoteDominio Cadastrar(PacoteDominio pacote);

        PacoteDominio Atualizar(PacoteDominio pacote);
    }
}
