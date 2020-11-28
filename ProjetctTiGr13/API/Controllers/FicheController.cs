using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetctTiGr13.Domain;
using ProjetctTiGr13.Infrastructure;

namespace ProjetctTiGr13.API.Controllers
{
    
    [ApiController]
   [Route("")] //A définir
    public class FicheController:ControllerBase
    {
        private IFicheRepository _ficheRepository = new SqlServerFicheRepository();

        [HttpGet]
        public ActionResult<IEnumerable<IFiche>> QueryAll()
        {
            return Ok(_ficheRepository.QueryAll().Cast<Fiche>());
        }
        
        
        [HttpGet]
        public ActionResult<IEnumerable<IFiche>> QueryAllByUser(string pseudo)
        {
            return Ok(_ficheRepository.QueryByPlayer(pseudo).Cast<Fiche>());
        }

        [HttpPost]
        public ActionResult<IFiche> Create([FromBody] IFiche fiche)
        {
            return Ok(_ficheRepository.Create(fiche));
        }
        
        
        [HttpDelete]
        [Route("")] //A définir
        public ActionResult Delete(int id_fiche)
        {
            if (_ficheRepository.Delete(id_fiche))
            {
                return Ok();
            }

            return NotFound();
        }
        
        
        [HttpPut]
        [Route("")] //A définir
        public ActionResult Put(int id_fiche, string id_joueur, [FromBody] IFiche fiche)
        {
            if (_ficheRepository.Update(id_fiche,id_joueur, fiche))
            {
                return Ok();
            }

            return NotFound();
        }

    }
}