using EntitiesLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Oglas> Oglas { get; set; }
        public virtual DbSet<Slike> Slike { get; set; }
        public virtual DbSet<Zanimljivi_oglasi> Zanimljivi_oglasi { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Korime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Broj_telefona)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Oglas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Korisnik_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Oglas1)
                .WithMany(e => e.Korisnik1)
                .Map(m => m.ToTable("Zanimljivi_oglasi").MapLeftKey("Korisnik_id").MapRightKey("Oglas_id"));

            modelBuilder.Entity<Oglas>()
                .Property(e => e.Naziv_oglasa)
                .IsUnicode(false);

            modelBuilder.Entity<Oglas>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Oglas>()
                .Property(e => e.Lokacija)
                .IsUnicode(false);

            modelBuilder.Entity<Oglas>()
                .Property(e => e.Kategorija)
                .IsUnicode(false);

            modelBuilder.Entity<Oglas>()
                .HasMany(e => e.Slike)
                .WithRequired(e => e.Oglas)
                .HasForeignKey(e => e.Oglas_id)
                .WillCascadeOnDelete(false);
        }
    }
}
