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
    [Route("api/funzionalità")]
    [Produces("application/json")]
    public class FunzionalitàController : ControllerBase
    {

        private readonly IFunzionalitàRepository _funzionalitàRepo;
        public FunzionalitàController(IFunzionalitàRepository repo)
        {
            _funzionalitàRepo = repo;
        }

        [HttpGet(Name = "GetFunzionalità")]
        public ActionResult<IEnumerable<FunzionalitàDto>> GetFunzionalità()
        {
            var test = _funzionalitàRepo.GetFunzionalità();
            return Ok(test);
        }


        [HttpPost]
        public IActionResult AddFunzionalità(
             [FromBody] FunzionalitàDto b)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("male male ");
            }

            var funzionalità = _funzionalitàRepo.AddFunzionalità(b);

            if (funzionalità == null)
            {
                return NotFound();
            }

            var newFunzionalità = new FunzionalitàDto
            {
                Name = b.Name,
                Id = b.Id,
                
            };

            return CreatedAtRoute("GetFunzionalità", newFunzionalità);

        }

        [HttpPut("{IdF:int}")]
        public ActionResult UpdateFunzionalità(
            int id,
            [FromBody] FunzionalitàDto b)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("male male ");
            }

            var funzionalità = _funzionalitàRepo.GetFunzionalità().FirstOrDefault(c => c.Id == id);

            if (funzionalità == null)
            {
                return NotFound();
            }

            _funzionalitàRepo.UpdateFunzionalità(b, funzionalità);

            return Ok(b);
        }

        [HttpDelete("{IdF:int}")]
        public ActionResult DeleteFunzionalità(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("male male ");
            }

            var funzionalità = _funzionalitàRepo.GetFunzionalità().FirstOrDefault(c => c.Id == id);

            if (funzionalità == null)
            {
                return NotFound();
            }

            _funzionalitàRepo.DeleteFunzionalità(funzionalità);


            return NoContent();
        }
    }
}
