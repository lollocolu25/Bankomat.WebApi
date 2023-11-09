using Bankomat.WebApi.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.WebApi.Repositories
{
    public class UtentiRepository : IUtentiRepository
    {
        public List<UtentiDto> Utenti { get; set; }
        public UtentiRepository()
        {
            Utenti = new List<UtentiDto>()
            {
                new UtentiDto()
                {
                    Id = 1,
                    IdBanca= 5,
                    NomeUtente = "Dario",
                    Password = "Dario",
                    Bloccato= 0,

                },
                new UtentiDto()
                {
                    Id = 2,
                    IdBanca= 3,
                    NomeUtente = "Carlo",
                    Password = "Carlo",
                    Bloccato= 0,
                },
                new UtentiDto()
                {
                    Id = 3,
                    IdBanca= 1,
                    NomeUtente = "Sara",
                    Password = "Sara",
                    Bloccato= 0,
                },
                new UtentiDto()
                {
                    Id = 4,
                    IdBanca= 2,
                    NomeUtente = "Anna",
                    Password = "Anna",
                    Bloccato= 0,
                },
                new UtentiDto()
                {
                    Id = 5,
                    IdBanca= 4,
                    NomeUtente = "Piero",
                    Password = "Piero",
                    Bloccato= 0,
                },
            };
        }


        public IEnumerable<UtentiDto> GetUtenti()
        {
            return Utenti;
        }

        public bool AddUtenti(UtentiDto utentis)
        {
            Utenti.Add(utentis);
            return true;
        }

        public bool DeleteUtenti(UtentiDto utentis)
        {
            int cont = 0;
            int position = -1;
            foreach (var Utente in Utenti)
            {

                if (utentis.Id == Utente.Id)
                {
                    position = cont;
                }
                cont++;

            }
            if(position==-1)
            {
                return false;
            }

            Utenti.RemoveAt(position);
            return true;
        }

        public bool UpdateUtenti(UtentiDto u)
        {
            var utenteToUpdate = Utenti.FirstOrDefault(x => x.Id == u.Id);
            utenteToUpdate.NomeUtente = u.NomeUtente;
            utenteToUpdate.Password = u.Password;
            utenteToUpdate.Bloccato = u.Bloccato;

            return true;
        }
    }
}

