namespace WebBanDoAnVatMup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("product")]
    public partial class product
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public decimal? price { get; set; }

        public string des { get; set; }

        public string image { get; set; }

        public int? quantity { get; set; }
    }
}
