using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo.Entity;
using BusinessLogic.Context;

namespace BusinessLogic.Context
{
    public class Context: DbContext
    {
        public Context() : base("Context")
        {
        }

        public DbSet<Lotti> lotti { get; set; }
        public DbSet<Richieste> SgateRichieste { get; set; }
        public DbSet<SgateReq> SgateRequest { get; set; }
        public DbSet<CapLotti> CapLots{ get; set; }
        public DbSet<Genere> Genere{ get; set; }
        public DbSet<Fornitori> Fornitori{ get; set; }
        public DbSet<Magazzino> Magazzino{ get; set; }
        public DbSet<Prodotto> Prodotto{ get; set; }
        public DbSet<Fattura> Fattura{ get; set; }
        public DbSet<Bolla> Bolla { get; set; }
        public DbSet<CapReq> CapRequest { get; set; }
        public DbSet<ComAnagrafica> Anagrafica{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { }
    }
}
