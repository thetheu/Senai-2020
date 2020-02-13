using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Pacotes")]
    public class PacoteDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        [Column("Titulo", TypeName = "varchar(100)")]
        public string Titulo { get; set; }

        [Required]
        [Column("Imagem", TypeName = "varchar(3000)")]
        public string Imagem { get; set; }

        [Required]
        [Column("Descricao", TypeName = "varchar(150)")]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataInicio { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataFim { get; set; }

        [Required]
        [Column("Pais", TypeName = "varchar(100)")]
        public string Pais { get; set; }

        [Required]
        [Column("Ativo", TypeName = "bit")]
        public bool Ativo { get; set; }

        [Required]
        [Column("Oferta", TypeName = "bit")]
        public bool Oferta { get; set; }




    }
}
