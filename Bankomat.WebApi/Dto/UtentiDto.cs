using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.Dto
{
    public class UtentiDto
    {
        public string NomeUtente { get; set; }
        public int Id { get; internal set; }
        public int IdBanca { get; internal set; }
        public string Password { get; set; }
        public int Bloccato { get; set; }

    }
}
