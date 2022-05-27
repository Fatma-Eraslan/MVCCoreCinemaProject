using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.DataBase.Entities;

namespace WebUI.Models.ViewModel
{
    public class FilmSeansVM
    {
        public Film Film { get; set; }
        public IEnumerable<Seans> Seanslar { get; set; }
    }
}
