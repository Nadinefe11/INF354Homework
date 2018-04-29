namespace INF354Greenhouse
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            ClientPlantStockSales = new HashSet<ClientPlantStockSale>();
        }

        public int ClientID { get; set; }

        public int? TitleID { get; set; }

        [StringLength(50)]
        public string ClientName { get; set; }

        [StringLength(50)]
        public string ClientSurname { get; set; }

        [StringLength(10)]
        public string ClientCell { get; set; }

        [StringLength(50)]
        public string ClientAddress { get; set; }

        [StringLength(30)]
        public string ClientEmail { get; set; }

        public virtual Title Title { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientPlantStockSale> ClientPlantStockSales { get; set; }
    }
}
