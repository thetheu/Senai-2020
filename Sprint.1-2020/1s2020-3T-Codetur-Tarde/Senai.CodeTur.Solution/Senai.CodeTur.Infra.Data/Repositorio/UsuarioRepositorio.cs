using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Contexto;
using Senai.CodeTur.Servico.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        /// <summary>
        /// Verificar se um usuario existe
        /// </summary>
        /// <param name="email">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>Retorna um objeto UsuarioDominio</returns>
        public UsuarioDominio EfetuarLogin(UsuarioViewModel login)
        {
            try
            {
                using (CodeTurContext ctx = new CodeTurContext())
                {
                    UsuarioDominio usuario = ctx.Usuarios.FirstOrDefault(x => x.Email == login.Email && x.Senha == login.Senha);
                    return usuario;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
