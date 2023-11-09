using Bankomat.WebApi.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.Repositories
{
    public class BancheFunzionalitàRepository : IBancheFunzionalitàRepository
    {
        public List<BancheFunzionalitàDto> BancheFunzionalità { get; set; }
        public BancheFunzionalitàRepository()
        {
            BancheFunzionalità = new List<BancheFunzionalitàDto>()
            {
                new BancheFunzionalitàDto()
                {
                    Id = 1,
                    Idbanca = 2,
                    IdFunzionalità = 1,

                },
                new BancheFunzionalitàDto()
                {
                    Id = 2,
                    Idbanca = 3,
                    IdFunzionalità = 3,

                },
                new BancheFunzionalitàDto()
                {
                    Id = 3,
                    Idbanca = 4,
                    IdFunzionalità = 3,

                },
                new BancheFunzionalitàDto()
                {
                    Id = 4,
                    Idbanca = 4,
                    IdFunzionalità = 1,

                },
                new BancheFunzionalitàDto()
                {
                    Id = 5,
                    Idbanca = 5,
                    IdFunzionalità = 1,

                },
                new BancheFunzionalitàDto()
                {
                    Id = 6,
                    Idbanca = 5,
                    IdFunzionalità = 3,

                },
                new BancheFunzionalitàDto()
                {
                    Id = 7,
                    Idbanca = 5,
                    IdFunzionalità = 4,

                },
            };
        }

        public IEnumerable<BancheFunzionalitàDto> GetBancheFunzionalità()
        {
            return BancheFunzionalità;
        }

        public bool AddBancheFunzionalità(BancheFunzionalitàDto bancheFunzionalitàs)
        {
            BancheFunzionalità.Add(bancheFunzionalitàs);
            return true;
        }

        public bool DeleteBancheFunzionalità(BancheFunzionalitàDto bancheFunzionalitàs)
        {
            BancheFunzionalità.Remove(bancheFunzionalitàs);
            return true;
        }

        public bool UpdateBancheFunzionalità(BancheFunzionalitàDto bf, BancheFunzionalitàDto bancheFunzionalità)
        {
            bancheFunzionalità.Id = bf.Id;
            bancheFunzionalità.Idbanca = bf.Idbanca;
            bancheFunzionalità.IdFunzionalità = bf.IdFunzionalità;
            return true;
        }

    }
}
