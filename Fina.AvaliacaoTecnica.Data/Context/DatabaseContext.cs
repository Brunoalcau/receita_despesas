using Fina.AvaliacaoTecnica.Data.Mapper;
using Fina.AvaliacaoTecnica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.AvaliacaoTecnica.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
           : base("name=AvaliacaoTecnica")
        {

        }
        public DbSet<Business> Business { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BusinessMap());
        }
    }
}
