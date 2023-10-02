using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.model
{
    public partial class TTCN : DbContext
    {
        public TTCN()
            : base("name=dbcontext")
        {
        }

        public virtual DbSet<CHI_TIET> CHI_TIET { get; set; }
        public virtual DbSet<NHA_CUNG_CAP> NHA_CUNG_CAP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHI_TIET>()
                .Property(e => e.MA_CHI_TIET)
                .IsUnicode(false);
        }
        public void GetData()
        {

        }
    }
}
