using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorio
{
    public class PacoteRepositorio : IPacoteRepositorio
    {
        public PacoteDominio Atualizar(PacoteDominio pacote)
        {
            using (CodeTurContext ctx = new CodeTurContext())
            {
                PacoteDominio PacoteBuscado = ctx.Pacotes.FirstOrDefault(x => x.Id == pacote.Id);
                PacoteBuscado.Titulo = pacote.Titulo;
                PacoteBuscado.Descricao = pacote.Descricao;
                PacoteBuscado.Imagem = pacote.Imagem;
                PacoteBuscado.Ativo = pacote.Ativo;
                PacoteBuscado.DataInicio = pacote.DataInicio;
                PacoteBuscado.DataFim = pacote.DataFim;
                PacoteBuscado.Pais = pacote.Pais;
                PacoteBuscado.Oferta = pacote.Oferta;
                ctx.Pacotes.Update(PacoteBuscado);
                ctx.SaveChanges();
                return pacote;
            }
        }


        public PacoteDominio BuscarPorId(int id)
        {
            using (CodeTurContext ctx = new CodeTurContext())
            {
                return ctx.Pacotes.FirstOrDefault(x => x.Id == id);
            }
        }


        public PacoteDominio Cadastrar(PacoteDominio pacote)
        {
            using (CodeTurContext ctx = new CodeTurContext())
            {
                ctx.Add(pacote);
                ctx.SaveChanges();
                return pacote;
            }
        }


        public List<PacoteDominio> Listar()
        {
            using (CodeTurContext ctx = new CodeTurContext())
            {
                return ctx.Pacotes.ToList();
            }
        }
    }
}
