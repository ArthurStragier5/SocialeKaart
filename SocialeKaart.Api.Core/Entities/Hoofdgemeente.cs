using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Entities
{
    public class Hoofdgemeente
    {
        public string Naam { get; set; }
        public List<Deelgemeente> Deelgemeentes { get; set; }
    }
}
