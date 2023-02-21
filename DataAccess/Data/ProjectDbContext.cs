using Microsoft.EntityFrameworkCore;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Data
{ 
    // Context : Db tabloları ile proje classlarını bağlamak
    public class ProjectDbContext : DbContext
    {
        // public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        // proje hangi veritabanı ile ilişkili
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //optionsBuilder.UseNpgsql(@"Host=localhost;Database=entitycore;Username=postgres;Password=mypassword");
        //    //optionsBuilder.UseNpgsql(@"Host=localhost;Database=HiperBankDB;Username=postgres;Password=g181210011");
        //    //modelBuilder.UseSerialColumns();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HiperBankDB;Trusted_Connection=true");
        }

        public DbSet<Bilanco> Bilanco { get; set; }
        //public DbSet<Core.Entities.Concrete.Enum> Enum { get; set; }
        public DbSet<EnumTuru> EnumTuru { get; set; }
        public DbSet<GercekMusteri> GercekMusteri { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<MusteriKayitKanali> MusteriKayitKanali { get; set; }
        public DbSet<TuzelMusteri> TuzelMusteri { get; set; }

    }
}
