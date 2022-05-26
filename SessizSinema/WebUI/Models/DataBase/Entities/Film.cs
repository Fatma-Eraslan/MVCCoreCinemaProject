using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.DataBase.Entities.Enum;

namespace WebUI.Models.DataBase.Entities
{
    public class Film:BaseEntity
    {
        public Film()
        {
            FilmCategoris = new HashSet<FilmCategori>();
            Seanslar = new HashSet<Seans>();
        }
        public string Ad { get; set; }
        [DataType(DataType.Currency)]
        public double Fiyat { get; set; }
        [DataType(DataType.Date)]
        public ICollection<Seans> Seanslar { get; set; }
        [DataType(DataType.Date)]
        public DateTime VizyonaGirisTarih { get; set; }
        [DataType(DataType.Date)]
        public DateTime VizyonDanKalkisTarih { get; set; }
        public string FilmOzet { get; set; }
        public double FilmSuresi { get; set; }
        public string FilmYönetmeni { get; set; }
        public string FilmPosterFotografYolu { get; set; }
        public IFormFile FilmPoster { get; set; }
        public ICollection<FilmCategori> FilmCategoris { get; set; }

    }
}
