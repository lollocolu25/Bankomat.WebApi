using Bankomat.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.Repositories
{
    public interface IUtentiRepository
    {
        IEnumerable<UtentiDto> GetUtenti();
        bool AddUtenti(UtentiDto utentis);
        bool DeleteUtenti(UtentiDto utentis);
        bool UpdateUtenti(UtentiDto u, UtentiDto utenti);
    }
}
