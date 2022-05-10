﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infosis_Banco.Data.Mappings
{
    public class DepositoMapping : IEntityTypeConfiguration<Deposito>
    {
        public void Configure(EntityTypeBuilder<Deposito> builder)
        {
            builder.Property(d => d.ValorDepositoFuncionario)
                .HasColumnType("DECIMAL")
                .IsRequired();

            builder.Property(d => d.Data)
                .HasColumnType("DATETIME")
                .IsRequired();
        }
    }
}
