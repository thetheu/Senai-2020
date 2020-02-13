using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Repositorio;

namespace Senai.CodeTur.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/Json")]
    [ApiController]
    public class PacoteController : ControllerBase
    {
        private IPacoteRepositorio PacoteRepositorio { get; set; }

        public PacoteController()
        {
            PacoteRepositorio = new PacoteRepositorio();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(PacoteRepositorio.Listar());
        }


        [Authorize]
        [HttpPost]
        public IActionResult Cadastrar(PacoteDominio pacote)
        {
            try
            {
                PacoteRepositorio.Cadastrar(pacote);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(new { mensagem = "Erro ao cadastrar" + e.Message });
            }
        }


        [Authorize]
        [HttpPut]
        public IActionResult Atualizar(PacoteDominio pacote)
        {
            try
            {
                PacoteDominio PacoteBuscado = PacoteRepositorio.BuscarPorId(pacote.Id);
                if (PacoteBuscado == null)
                    return NotFound();

                PacoteRepositorio.Atualizar(pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro Ao Atualizar Categoria" });
            }
        }


        [Authorize]
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            PacoteDominio Pacote = PacoteRepositorio.BuscarPorId(id);
            if (Pacote == null)
                return NotFound();
            return Ok(Pacote);
        }
    }
}