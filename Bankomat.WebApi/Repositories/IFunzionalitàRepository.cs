using Bankomat.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.Repositories
{
    public interface IFunzionalitàRepository
    {
        IEnumerable<FunzionalitàDto> GetFunzionalità();
        bool AddFunzionalità(FunzionalitàDto funzionalitàs);
        bool DeleteFunzionalità(FunzionalitàDto funzionalitàs);
        bool UpdateFunzionalità(FunzionalitàDto bf, FunzionalitàDto funzionalità);
    }
}
