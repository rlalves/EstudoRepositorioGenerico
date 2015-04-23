using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

using Cv2.Dominio.Entidades;

namespace Cv2.Persistencia.Config.Entidades
{
    class ConfigPessoa : EntityTypeConfiguration<Pessoa>
    {
        public ConfigPessoa()
        {
            HasKey(p => p.PessoaId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
