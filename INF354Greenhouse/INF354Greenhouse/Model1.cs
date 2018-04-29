namespace INF354Greenhouse
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientPlantStockSale> ClientPlantStockSales { get; set; }
        public virtual DbSet<PlantStock> PlantStocks { get; set; }
        public virtual DbSet<PlantType> PlantTypes { get; set; }
        public virtual DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
