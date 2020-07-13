using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CodenationRestaurante.Dominio.Modelo;

namespace CodenationRestaurante.Dados
{
    class Contexto : DbContext
    {
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Prato> Prato { get; set; }
        public DbSet<TipoPrato> TipoPrato { get; set; }
        public DbSet<Agenda> DiaCardapio { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-13OHB8K\SQLEXPRESS;Database=CodenationRestaurante;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
