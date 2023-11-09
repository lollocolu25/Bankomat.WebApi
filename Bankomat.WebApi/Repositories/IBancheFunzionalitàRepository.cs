using Bankomat.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.Repositories
{
    public interface IBancheFunzionalitàRepository
    {
        IEnumerable<BancheFunzionalitàDto> GetBancheFunzionalità();
        bool AddBancheFunzionalità(BancheFunzionalitàDto bancheFunzionalitàs);
        bool DeleteBancheFunzionalità(BancheFunzionalitàDto bancheFunzionalitàs);
        bool UpdateBancheFunzionalità(BancheFunzionalitàDto bf, BancheFunzionalitàDto bancheFunzionalità);
    }
}
