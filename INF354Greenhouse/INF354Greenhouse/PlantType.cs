namespace INF354Greenhouse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlantType")]
    public partial class PlantType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlantType()
        {
            PlantStocks = new HashSet<PlantStock>();
        }

        public int PlantTypeID { get; set; }

        [Column("PlantType")]
        [StringLength(50)]
        public string PlantType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlantStock> PlantStocks { get; set; }
    }
}
