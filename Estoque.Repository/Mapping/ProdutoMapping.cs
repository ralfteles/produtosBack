using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Repository.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produto");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                   .HasColumnName("nome")
                   .HasMaxLength(300);

            builder.Property(x => x.Valor)
                   .HasColumnName("valor");

            builder.Property(x => x.Imagem)
                   .HasColumnName("imagem");

            builder.Property(x => x.DataDeCadastro)
                   .HasColumnName("dataDeCadastro");

            builder.Property(x => x.DataDeAlteracao)
                   .HasColumnName("dataDeAlteracao");

            builder.Property(x => x.Lixeira)
                   .HasColumnName("lixeira");

        }
    }
}
