using Microsoft.EntityFrameworkCore;
using Senai.CodeTur.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Contexto
{
    public class CodeTurContext : DbContext
    {
        public DbSet<UsuarioDominio> Usuarios { get; set; }
        public DbSet<PacoteDominio> Pacotes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS3TT; initial catalog=codetur;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDominio>().HasData(new UsuarioDominio()
            {
                Id = 1,
                Email = "fernando.guerra@sp.senai.br",
                Senha = "senai132",
                Tipo = "Adm"
            });

            modelBuilder.Entity<PacoteDominio>().HasData(new PacoteDominio()
            {
                Id = 1,
                Titulo = "Tour Europa",
                Imagem = "https://www.passagenspromo.com.br/blog/wp-content/uploads/2019/05/tour-pela-europa-740x415.jpg",
                Descricao = "Um tour feito passando pela maioria dos paises europeus, que abrangera grandes polos de tecnologia mundial",
                DataInicio = DateTime.Parse("2020-07-10"),
                DataFim = DateTime.Parse("2020-11-05"),
                Pais = "Portugal, Espanha, França, Italia, Grecia, Inglaterra",
                Ativo = true,
                Oferta = false,

            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
