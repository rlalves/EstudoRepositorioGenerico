using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Cv2.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

using Cv2.Persistencia.Config.Entidades;
using Cv2.Persistencia.Migrations;

namespace Cv2.Persistencia.Contexto
{
    public class Modelo : DbContext
    {
        public Modelo()
            : base("Cv2.Dados")
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ConfigPessoa());
        }
    }
}
