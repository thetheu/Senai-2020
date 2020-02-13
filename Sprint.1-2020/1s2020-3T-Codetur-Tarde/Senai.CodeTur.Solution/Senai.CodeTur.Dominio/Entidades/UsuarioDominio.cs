using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Usuarios")]
    public class UsuarioDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Email", TypeName = "varchar(150)")]
        public string Email { get; set; }
        [Required]

        [Column("Senha ", TypeName = "varchar(20)")]
        public string Senha { get; set; }

        [Required]
        [Column("Tipo", TypeName = "varchar(30)")]
        public string Tipo { get; set; }

    }
}

public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Title { get; set; }
}


