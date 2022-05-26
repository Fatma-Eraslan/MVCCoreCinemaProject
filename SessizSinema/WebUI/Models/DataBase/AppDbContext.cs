using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.DataBase.Entities;
using WebUI.Models.DataBase.Entities.Enum;

namespace WebUI.Models.DataBase
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Seans> Seanslar { get; set; }
        public DbSet<FilmCategori> FilmCategorileri { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmCategori>().HasData(new FilmCategori { Id = 1, KategoriAdi = FilmTuru.Aksiyon.ToString() });
            modelBuilder.Entity<FilmCategori>().HasData(new FilmCategori { Id = 2, KategoriAdi = FilmTuru.Animasyon.ToString() });
            modelBuilder.Entity<FilmCategori>().HasData(new FilmCategori { Id = 3, KategoriAdi = FilmTuru.BilimKurgu.ToString() });
            modelBuilder.Entity<FilmCategori>().HasData(new FilmCategori { Id = 4, KategoriAdi = FilmTuru.Fantastik.ToString() });
            modelBuilder.Entity<FilmCategori>().HasData(new FilmCategori { Id = 5, KategoriAdi = FilmTuru.Gerilim.ToString() });
            modelBuilder.Entity<FilmCategori>().HasData(new FilmCategori { Id = 6, KategoriAdi = FilmTuru.Komedi.ToString() });

            modelBuilder.Entity<Seans>().HasData(new Seans { Id = 1, Saati = "10:00" });
            modelBuilder.Entity<Seans>().HasData(new Seans { Id = 2, Saati = "12:00" });
            modelBuilder.Entity<Seans>().HasData(new Seans { Id = 3, Saati = "14:00" });
            modelBuilder.Entity<Seans>().HasData(new Seans { Id = 4, Saati = "16:00" });
            modelBuilder.Entity<Seans>().HasData(new Seans { Id = 5, Saati = "18:00" });
            modelBuilder.Entity<Seans>().HasData(new Seans { Id = 6, Saati = "20:00" });
            modelBuilder.Entity<Seans>().HasData(new Seans { Id = 7, Saati = "22:00" });

            modelBuilder.Entity<Film>().Ignore(a => a.FilmPoster);
        }
    }
}
