using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebBanDoAnVatMup.Models
{
    public partial class banDoAnVatMup_DB : DbContext
    {
        public banDoAnVatMup_DB()
            : base("name=banDoAnVatMup_DB")
        {
        }

        public virtual DbSet<account_user> account_user { get; set; }
        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account_user>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<account_user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);
        }
    }
}
