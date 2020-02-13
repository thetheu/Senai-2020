using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Servico.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio
    {
        UsuarioDominio EfetuarLogin(UsuarioViewModel login);
    }
}
