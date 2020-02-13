using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Senai.CodeTur.Servico.ViewModels
{
    public class UsuarioViewModel
        {
            [Required]
            public string Email { get; set; }
            [StringLength(30, MinimumLength = 4)]
            public string Senha { get; set; }
        }
    }

