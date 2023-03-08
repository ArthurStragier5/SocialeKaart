using SocialeKaart.Api.Core.Dtos;
using SocialeKaart.Api.Core.Repositories.Interfaces;
using SocialeKaart.Api.Core.Repositories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Services
{
    public class LogoService : ILogoService
    {
        private readonly ILogoRepository _logoRepository;
        private const string ReadRange = "Data!A2:AZ";

        private readonly ISheetService _sheetService;
        private readonly IXmlService _xmlService;

        public LogoService(ILogoRepository logoRepository, ISheetService sheetService, IXmlService xmlService)
        {
            _logoRepository = logoRepository;
            _sheetService = sheetService;
            _xmlService = xmlService;
        }

        public Task<IEnumerable<LogoResponseDto>> ListALl()
        {
            throw new NotImplementedException();
        }
    }
}
