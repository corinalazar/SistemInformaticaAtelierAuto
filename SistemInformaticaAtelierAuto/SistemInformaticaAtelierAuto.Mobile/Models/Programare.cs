using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformaticaAtelierAuto.Mobile.Models
{
    public class Programare
    {
        public int Id { get; set; }
        public string Masina { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Descriere { get; set; } = string.Empty;
    }
}