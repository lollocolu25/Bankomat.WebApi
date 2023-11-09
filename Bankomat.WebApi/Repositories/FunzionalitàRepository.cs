using Bankomat.WebApi.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.Repositories
{
    public class FunzionalitàRepository : IFunzionalitàRepository
    {
        public List<FunzionalitàDto> Funzionalità { get; set; }
        public FunzionalitàRepository()
        {
            Funzionalità = new List<FunzionalitàDto>()
            {
                new FunzionalitàDto()
                {
                    Id = 1,
                    Name = "Report Saldo",
                },
                new FunzionalitàDto()
                {
                    Id = 2,
                    Name = "Versamento",
                },
                new FunzionalitàDto()
                {
                    Id = 3,
                    Name = "Prelievo",
                },
                new FunzionalitàDto()
                {
                    Id = 4,
                    Name = "Registro Operazioni",
                },
            };
        }

    


        public IEnumerable<FunzionalitàDto> GetFunzionalità()
        {
            return Funzionalità;
        }

        public bool AddFunzionalità(FunzionalitàDto funzionalitàs)
        {
            Funzionalità.Add(funzionalitàs);
            return true;
        }

        public bool DeleteFunzionalità(FunzionalitàDto funzionalitàs)
        {
            Funzionalità.Remove(funzionalitàs);
            return true;
        }

        public bool UpdateFunzionalità(FunzionalitàDto bf, FunzionalitàDto funzionalità)
        {
            funzionalità.Name = bf.Name;
            funzionalità.Id = bf.Id;
            return true;
        }
    }
}
