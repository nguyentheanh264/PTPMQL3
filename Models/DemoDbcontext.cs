using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL3.Models
{
    public partial class DemoDbcontext : DbContext
    {
        public DemoDbcontext()
            : base("name=DemoDbcontext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
