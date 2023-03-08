using SocialeKaart.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Entities
{
    public class Psychiater : EntityBase
    {
       // public int Id { get; set; }
        public string Naam { get; set; }
        public string Diploma { get; set; }
        public string Aanbod { get; set; }
        public string TherapInvalshoek { get; set; }
        public string Specialisaties { get; set; }
        public string PrijsMetRiziv { get; set; }
        public string PrijsZonderRiziv { get; set; }
        public string BijkomendeGeg { get; set; }
        public List<Praktijk> Praktijken { get; set; }
    }
}
