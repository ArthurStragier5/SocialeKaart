using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Entities
{
    public class Psycholoog
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beroepsgroep { get; set; }
        public string Werkgebied { get; set; }
        public string AantalVestigingen { get; set; }
        public string Diploma { get; set; }
        public string Doelgroep { get; set; }
        public string Lidmaatschap { get; set; }
        public string TherapInvalshoek { get; set; }
        public string Specialisaties { get; set; }
        public string AmbulantWerken { get; set; }
        public string PrijsMetRiziv { get; set; }
        public string PrijsZonderRiziv { get; set; }
        public string IqOnderzoek { get; set; }
        public string BijkomendeGeg1 { get; set; }
        public string BijkomendeGeg2 { get; set; }
        public List<Praktijk> Praktijken { get; set; }
    }
}
