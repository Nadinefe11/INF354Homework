namespace INF354Greenhouse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlantStock")]
    public partial class PlantStock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlantStock()
        {
            ClientPlantStockSales = new HashSet<ClientPlantStockSale>();
        }

        public int PlantStockID { get; set; }

        [StringLength(30)]
        public string PlantStockName { get; set; }

        public int? PlantTypeID { get; set; }

        public double? UnitPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientPlantStockSale> ClientPlantStockSales { get; set; }

        public virtual PlantType PlantType { get; set; }
    }
}
