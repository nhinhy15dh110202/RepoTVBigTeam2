namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TVBigTeam2DbContext : DbContext
    {
        public TVBigTeam2DbContext()
            : base("name=TVBigTeam2DbContext")
        {
        }

        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
