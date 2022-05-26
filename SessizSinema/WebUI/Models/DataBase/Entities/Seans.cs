using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.DataBase.Entities
{
    public class Seans : BaseEntity
    {
        public Seans()
        {
            Filmler = new HashSet<Film>();
        }
        public string Saati { get; set; }
        public ICollection<Film> Filmler { get; set; }
    }
}
