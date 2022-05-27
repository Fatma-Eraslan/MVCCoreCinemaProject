using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.DataBase.Entities;

namespace WebUI.Models.ViewModel
{
    public class FilmCategoriVM
    {
        public Film Film { get; set; }
        public IEnumerable<FilmCategori> FilmCategorieri { get; set; }
    }
}
