using Bankomat.WebApi.Dto;
using Bankomat.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bankomat.WebApi.Controller
{

    [ApiController]
    [Route("api/utenti")]
    [Produces("application/json")]
    public class UtentiController : ControllerBase
    {

        private readonly IUtentiRepository _utentiRepo;
        //private readonly IDbRepository _DbRepo;
        public UtentiController(IUtentiRepository repo, IDbUtentiRepository dbrepo)
        {
            _utentiRepo = repo;
            //_DbRepo = dbrepo;
        }

        //[HttpGet]
        //    public async Task<ActionResult<IEnumerable<UtentiDto>>>GetUtenti(){
        //        IEnumerable<Entities.Utenti> utenti = await _DbRepo.GetUtentiAsync();
        //        return Ok(utenti);
        //    }

        //[HttpGet("{id}", Name = nameof(GetUtenti))]
        //    public async Task<ActionResult<UtentiDto>> GetUtenti(int id)
        //    {
        //        var utentiToReturn = _DbRepo.GetUtentiAsync()
        //            .Result.ToList().FirstOrDefault(p => p.Id == id);
        //        if(utentiToReturn == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(utentiToReturn);

           
        //    }


        [HttpGet(Name = "GetUtenti")]
            public ActionResult<IEnumerable<UtentiDto>> GetUtenti()
            {
                var test = _utentiRepo.GetUtenti();
                return Ok(test);
            }

        //[HttpPost]
        //public ActionResult CreateUser([FromBody] Models.Utenti utenti)
        //{
        //    if(
        //}


            [HttpPost]
            public IActionResult AddUtenti(
                 [FromBody] UtentiDto b)
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest("male male ");
                }

                var utenti = _utentiRepo.AddUtenti(b);

                if (utenti == null)
                {
                    return NotFound();
                }

                var newUtente = new UtentiDto
                {
                    NomeUtente = b.NomeUtente,
                    Id = b.Id,
                    IdBanca= b.IdBanca,
                    Password = b.Password,
                    Bloccato = b.Bloccato,

                };

                return CreatedAtRoute("GetUtenti", newUtente);

            }

            [HttpPut("{IdU:int}")]
            public ActionResult UpdateUtenti(
                int id,
                [FromBody] UtentiDto b)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("male male ");
                }

                var utenti = _utentiRepo.GetUtenti().FirstOrDefault(c => c.Id == id);

                if (utenti == null)
                {
                    return NotFound();
                }

                _utentiRepo.UpdateUtenti(b, utenti);

                return Ok(b);
            }

            [HttpDelete("{IdU:int}")]
            public ActionResult DeleteUtenti(int id)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("male male ");
                }

                var utenti = _utentiRepo.GetUtenti().FirstOrDefault(c => c.Id == id);

                if (utenti == null)
                {
                    return NotFound();
                }

                _utentiRepo.DeleteUtenti(utenti);


                return NoContent();
            }
        }
    
}
