using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ukolnicek.Models
{
    public class Ukol
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Název úkolu")]
        public string NazevUkolu { get; set; }
        [DisplayName("Druh práce")]
        public string DruhPrace { get; set; }
        [DisplayName("Začátek")]
        public DateTime CasOd { get; set; }
        [DisplayName("Konec")]
        public DateTime CasDo { get; set; }
    }
}
