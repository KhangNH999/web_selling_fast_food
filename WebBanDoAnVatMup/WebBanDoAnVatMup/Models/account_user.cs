namespace WebBanDoAnVatMup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account_user")]
    public partial class account_user
    {
        public int id { get; set; }

        [StringLength(20)]
        public string user_name { get; set; }

        [StringLength(255)]
        public string password { get; set; }
    }
}
