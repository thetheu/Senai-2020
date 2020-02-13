using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Repositorio;
using Senai.CodeTur.Servico.ViewModels;

namespace Senai.CodeTur.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepositorio UsuarioRepositorio { get; set; }

        public UsuarioController()
        {
            UsuarioRepositorio = new UsuarioRepositorio();
        }

        [HttpPost]
        public IActionResult Login(UsuarioViewModel login)
        {
            try
            {
                UsuarioDominio usuarioBuscado = UsuarioRepositorio.EfetuarLogin(login);
                if (usuarioBuscado == null)
                    return NotFound(new { mensagem = "Email ou Senha Inválidos." });

                // informacoes referentes ao usuarios
                var claims = new[]
               {
                    new Claim("Permissao", usuarioBuscado.Tipo),
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.Id.ToString()),
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("codeTur-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "CodeTur.WebApi",
                    audience: "CodeTur.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Erro ao cadastrar." + ex});
            }
        }


    }
}