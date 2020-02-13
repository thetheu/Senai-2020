using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Senai.CodeTur.Teste.XUnit.Repositorios
{
    public class TestePacote
    {
        private IPacoteRepositorio _pacoteRepositorio;

        public TestePacote()
        {
            _pacoteRepositorio = new PacoteRepositorio();
        }

        [Fact]
        public void ListarPacote()
        {
            var pacote = _pacoteRepositorio.Listar();

            Assert.NotNull(pacote);
        }

        [Fact]
        public void CadastrarPacote()
        {
            PacoteDominio pacote = new PacoteDominio()
            {
                Titulo = "Viagem a Dubai",
                Imagem = "https://upload.wikimedia.org/wikipedia/pt/thumb/9/93/Burj_Khalifa.jpg/220px-Burj_Khalifa.jpg",
                Descricao = "Uma viagem inesquecivel para o mair polo tecnologico do mundo.",
                DataInicio = DateTime.Parse("03/02/2020"),
                DataFim = DateTime.Parse("10/02/2020"),
                Pais = "Emirados Árabe",
                Ativo = true,
                Oferta = false,
            };

            var pacoteCadastrado = _pacoteRepositorio.Cadastrar(pacote);

            Assert.NotNull(pacote);
        }

        [Fact]
        public void Atualizar()
        {
            PacoteDominio pacote = _pacoteRepositorio.BuscarPorId(1);
            {
                pacote.Titulo = "Viagem a Dubai";
            }

            var pacoteAtualizado = _pacoteRepositorio.Atualizar(pacote);

            Assert.NotNull(pacoteAtualizado);
        }

        [Fact]
        public void BuscarPorId()
        {
            var pacote = _pacoteRepositorio.BuscarPorId(1);

            Assert.NotNull(pacote);
        }

    }
}
