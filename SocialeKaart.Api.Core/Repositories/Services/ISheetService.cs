using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialeKaart.Api.Core.Repositories.Services
{
    public interface ISheetService
    {
        SheetsService GetSheetsService();
    }
}
