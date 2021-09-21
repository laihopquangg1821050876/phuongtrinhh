using phuongtrinhb1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiaiptBac1.Models
{
    public partial class LTQLDbContext : DbContext

    {
        public LTQLDbContext() : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<khachhang> Khachhangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .Property(e => e.Username)
            .IsUnicode(false);
            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

        }
    }
}
