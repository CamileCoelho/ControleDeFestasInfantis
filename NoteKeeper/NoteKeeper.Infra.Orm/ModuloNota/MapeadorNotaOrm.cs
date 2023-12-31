﻿using Microsoft.EntityFrameworkCore;
using NoteKeeper.Dominio.ModuloNota;

namespace NoteKeeper.Infra.Orm.ModuloNota
{
    public class MapeadorNotaOrm : IEntityTypeConfiguration<Nota>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Nota> builder)
        {
            builder.ToTable("TBNota");

            builder.Property(x => x.Id)
            .ValueGeneratedNever();

            builder.Property(x => x.Titulo)
            .IsRequired();

            builder.Property(x => x.Conteudo)
            .IsRequired();

            builder.Property(x => x.Tema)
           .IsRequired();

            builder.Property(x => x.Tema)
            .HasConversion<int>()
           .IsRequired();

            builder.Property(x => x.Arquivada)
           .IsRequired();

            builder.HasOne(x => x.Categoria)
            .WithMany()
            .HasForeignKey(x => x.CategoriaId)
            .HasConstraintName("FK_TBCategoria_TBNota")
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
