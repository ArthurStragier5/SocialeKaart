using SocialeKaart.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Repositories.Services
{
    public interface ILogoService
    {
        Task<IEnumerable<LogoResponseDto>> ListALl();
    }
}
