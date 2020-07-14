using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dados.Map;
using RestauranteCodenation.Data.Map;

namespace CodenationRestaurante.Dados
{
    class Contexto : DbContext
    {
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Prato> Prato { get; set; }
        public DbSet<TipoPrato> TipoPrato { get; set; }
        public DbSet<Agenda> DiaCardapio { get; set; }
        public DbSet<PratosIngredientes> PratosIngredientes { get; set; }
        public DbSet<AgendaCardapio> AgendaCardapio { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-13OHB8K\SQLEXPRESS;Database=CodenationRestaurante;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new IngredienteMap());
            modelBuilder.ApplyConfiguration(new PratoMap());
            modelBuilder.ApplyConfiguration(new PratosIngredientesMap());
            modelBuilder.ApplyConfiguration(new TipoPratoMap());
            modelBuilder.ApplyConfiguration(new AgendaCardapioMap());
            modelBuilder.ApplyConfiguration(new AgendaMap());
            modelBuilder.ApplyConfiguration(new CardapioMap());
        }
    }
}
