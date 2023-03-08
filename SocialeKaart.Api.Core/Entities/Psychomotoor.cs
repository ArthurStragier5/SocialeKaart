using SocialeKaart.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Entities
{
    public class Psychomotoor : EntityBase
    {
       // public int Id { get; set; }
        public string Naam { get; set; }
        public string Init { get; set; }
        public string AantalVestigingen { get; set; }
        public string Diploma { get; set; }
        public string Doelgroep { get; set; }
        public string Specialisaties { get; set; }
        public string AndereSpecialisaties { get; set; }
        public string AmbulantWerken { get; set; }
        public string PrijsMetRiziv { get; set; }
        public string PrijsZonderRiziv { get; set; }
        public string BijkomendeGeg1 { get; set; }
        public string BijkomendeGeg2 { get; set; }
        public string IqOnderzoek { get; set; }

        public List<Praktijk> Praktijken { get; set; }
    }
}
