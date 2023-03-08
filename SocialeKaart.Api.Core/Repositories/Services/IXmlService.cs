using SocialeKaart.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Repositories.Services
{
    public interface IXmlService
    {
        Configuratie ReadXmlFile();
        Configuratie UpdateXmlFile(Configuratie config);
    }
}
