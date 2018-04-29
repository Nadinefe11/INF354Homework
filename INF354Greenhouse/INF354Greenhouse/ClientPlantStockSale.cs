namespace INF354Greenhouse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientPlantStockSale")]
    public partial class ClientPlantStockSale
    {
        public int ClientPlantStockSaleID { get; set; }

        public int? PlantStockID { get; set; }

        public int? ClientID { get; set; }

        public DateTime? SaleDate { get; set; }

        public virtual Client Client { get; set; }

        public virtual PlantStock PlantStock { get; set; }
    }
}
