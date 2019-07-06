using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace IPTTransportes.Models
{
    public class IPTTransportesDB : DbContext
    {
        // *******************************************************************
        // IPTTransportesDB

        public IPTTransportesDB() : base("IPTTransportesDBConnectionString") { }

        // vamos colocar, aqui, as instruções relativas às tabelas do 'negócio'
        // descrever os nomes das tabelas na Base de Dados
        public virtual DbSet<Utilizadores> Utilizadores { get; set; } // tabela Utilizadores
        public virtual DbSet<Cliente> Cliente { get; set; } // tabela Cliente
        public virtual DbSet<Gestor> Gestor { get; set; } // tabela Gestor
        public virtual DbSet<Transportador> Transportador { get; set; } // tabela Transportador

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<IPTTransportes.Models.Transportadora> Transportadoras { get; set; }
    }
}