using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.Dto
{
    public class BancheFunzionalitàDto
    {
        public int Id { get; internal set; }
        public int Idbanca { get; set; }
        public int IdFunzionalità { get; set; }

    }
}
