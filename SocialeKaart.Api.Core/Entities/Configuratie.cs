using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Entities
{
    public class Configuratie
    {
        public string SpreadSheetLogosId { get; set; }
        public string SpreadSheetPsyosId { get; set; }
        public string SpreadSheetElzId { get; set; }
        public string SpreadSheetPsyasId { get; set; }
        public string SpreadSheetPsymsId { get; set; }
        public string SpreadSheetAccountsId { get; set; }
        public string SpreadNieuwePsymsId { get; set; }

        public string LogosToevoegen { get; set; }
        public string LogosWijzigen { get; set; }
        public string PsymsToevoegen { get; set; }


        public string PsyosToevoegen { get; set; }
        public string PsyosWijzigen { get; set; }

        public string PsyasToevoegen { get; set; }
        public string PsyasWijzigen { get; set; }

        public string LogoNavItem { get; set; }
        public string PsyoNavItem { get; set; }
        public string PsyaNavItem { get; set; }
        public string PsymNavItem { get; set; }

        public string EersteKleur { get; set; }
        public string TweedeKleur { get; set; }
    }
}
