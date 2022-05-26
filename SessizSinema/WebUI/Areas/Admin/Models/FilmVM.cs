using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.DataBase.Entities;

namespace WebUI.Areas.Admin.Models
{
    public class FilmVM
    {
        public Film Film { get; set; }
        public IEnumerable<FilmCategori> FilmCategorileri { get; set; }
        public IEnumerable<Seans> Seanslar { get; set; }
    }
}
