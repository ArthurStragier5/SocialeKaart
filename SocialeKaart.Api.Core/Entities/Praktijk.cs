using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Entities
{
    public class Praktijk
    {
        public string PraktijkNaam { get; set; }
        public string AardPraktijk { get; set; }
        public string PlaatsHoofdact { get; set; }
        public string GemeenteHoofdact { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Telefoon { get; set; }
        public string Mobiel { get; set; }
        public string Website { get; set; }
    }
}
