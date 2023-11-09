using Bankomat.WebApi.Dto;
using Bankomat.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bankomat.WebApi.Controller
{
    
        [ApiController]
        [Route("api/bancheFunzionalità")]
        [Produces("application/json")]
        public class BancheFunzionalitàController : ControllerBase
        {

            private readonly IBancheFunzionalitàRepository _banchefunzionalitàRepo;
            public BancheFunzionalitàController(IBancheFunzionalitàRepository repo)
            {
            _banchefunzionalitàRepo = repo;
            }

            [HttpGet(Name = "GetBancheFunzionalità")]
            public ActionResult<IEnumerable<BancheFunzionalitàDto>> GetBancheFunzionalità()
            {
                var test = _banchefunzionalitàRepo.GetBancheFunzionalità();
                //return _bibiteRepo.GetBibite().ToList();
                return Ok(test);
            }


            [HttpPost]
            public IActionResult AddBancheFunzionalità(
                 [FromBody] BancheFunzionalitàDto b)
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest("male male ");
                }

                var banchefunzionalità = _banchefunzionalitàRepo.AddBancheFunzionalità(b);

                if (banchefunzionalità == null)
                {
                    return NotFound();
                }

                var newbanchefunzionalità = new BancheFunzionalitàDto
                {
                    Id = b.Id,
                    Idbanca = b.Idbanca,
                    IdFunzionalità = b.IdFunzionalità
                };

                return CreatedAtRoute("GetBancheFunzionalità", newbanchefunzionalità);

            }

            [HttpPut("{IdBf:int}")]
            public ActionResult UpdateBancheFunzionalità(
                int id,
                [FromBody] BancheFunzionalitàDto b)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("male male ");
                }

                var banchefunzionalità = _banchefunzionalitàRepo.GetBancheFunzionalità().FirstOrDefault(c => c.Id == id);

                if (banchefunzionalità == null)
                {
                    return NotFound();
                }

            _banchefunzionalitàRepo.UpdateBancheFunzionalità(b, banchefunzionalità);

                return Ok(b);
            }

            [HttpDelete("{IdBf:int}")]
            public ActionResult DeleteBancheFunzionalità(int id)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("male male ");
                }

                var banchefunzionalità = _banchefunzionalitàRepo.GetBancheFunzionalità().FirstOrDefault(c => c.Id == id);

                if (banchefunzionalità == null)
                {
                    return NotFound();
                }

            _banchefunzionalitàRepo.DeleteBancheFunzionalità(banchefunzionalità);


                return NoContent();
            }
        }
    
}
