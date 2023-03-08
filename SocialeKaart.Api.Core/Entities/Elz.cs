using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Entities
{
    public class Elz
    {
        public string Naam { get; set; }
        public List<Hoofdgemeente> Hoofdgemeentes { get; set; }
    }
}
