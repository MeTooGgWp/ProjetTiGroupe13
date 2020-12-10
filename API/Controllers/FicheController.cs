using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models.FicheModel;
using ProjetctTiGr13.Domain;
using ProjetctTiGr13.Infrastructure;

namespace ProjetctTiGr13.API.Controllers
{
    
    [ApiController]
    [Route("api/fiche")] //A définir
    public class FicheController:ControllerBase
    {
       // private IFicheRepository _ficheRepository = new SqlServerFicheRepository();
       private db_fiche_persoContext context = new db_fiche_persoContext();

        [HttpGet]
        public ActionResult<IEnumerable<Fiche>> QueryAll()
        {
           // return Ok(_ficheRepository.QueryAll().Cast<Fiche>());
           var fiches = context.Fiches.ToList();
           return Ok(fiches);
        }
        
        
        [HttpGet]
        [Route("{pseudo}")]
        public ActionResult<IEnumerable<Fiche>> QueryAllByUser(string pseudo)
        {
            
            //return Ok(_ficheRepository.QueryByPlayer(pseudo).Cast<Fiche>());
            var fiches = context.Fiches
                .Where(f => f.IdJoueur == pseudo)
                .ToList();
            return Ok(fiches);
        }

        [HttpPost]
        public ActionResult<Fiche> Create([FromBody] Fiche fiche)
        {
            //return Ok(_ficheRepository.Create(fiche));
            context.Fiches.Add(fiche);
            return Ok(context.SaveChanges());
        }
        
        
        [HttpDelete]
        [Route("{id_fiche:int}")] //A définir
        public ActionResult Delete(int id_fiche)
        {
           /* if (_ficheRepository.Delete(id_fiche))
            {
                return Ok();
            }*/

           var listFiche = context.Fiches
               .Where(f => f.IdFiche == id_fiche)
               .ToList();
           if (listFiche.Count == 1)
           {
               var toDelete = listFiche[0];
               context.Fiches.Remove(toDelete);
               return Ok(context.SaveChanges());
           }
           
           

            return NotFound();
        }
        
        
        [HttpPut]
        [Route("{id_fiche:int}/{id_joueur}")] //A définir
        public ActionResult Put(int id_fiche, string id_joueur, [FromBody] IFiche fiche)
        {
            /*if (_ficheRepository.Update(id_fiche,id_joueur, fiche))
            {
                return Ok();
            }*/
            

            return NotFound();
        }

    }
}