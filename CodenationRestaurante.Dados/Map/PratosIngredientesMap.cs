using CodenationRestaurante.Dominio.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodenationRestaurante.Dados.Map
{
    class PratosIngredientesMap : IEntityTypeConfiguration<PratosIngredientes>
    {
        public void Configure(EntityTypeBuilder<PratosIngredientes> builder)
        {
            builder.ToTable("PratosIngredientes");

            builder.HasKey(t => new { t.IdIngrediente, t.IdPrato});

            builder.HasOne(i => i.Ingrediente)
                .WithMany(pi => pi.PratosIngredientes)
                .HasForeignKey(i => i.IdIngrediente);

            builder.HasOne(p => p.Prato)
                .WithMany(pi => pi.PratosIngredientes)
                .HasForeignKey(p => p.IdPrato);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
