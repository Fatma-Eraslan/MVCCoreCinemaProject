using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.DataBase.Entities.Enum;

namespace WebUI.Models.DataBase.Entities
{
    public class FilmCategori 
    {
        public FilmCategori()
        {
            Films = new HashSet<Film>();
        }
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
