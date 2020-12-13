using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Infrastructure.Factories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.FicheModel;
using ProjetctTiGr13;
using ProjetctTiGr13.Domain;
using ProjetctTiGr13.Domain.FicheComponent;
using ProjetctTiGr13.Helpers;

namespace API.Controllers
{
    
    [ApiController]
    [Route("api/fiche")] //A définir
    public class FicheController:ControllerBase
    {
        private db_fiche_persoContext context;

       public FicheController(db_fiche_persoContext context)
       {
           this.context = context;
       }
       
       //Instaciation du mapper (pour convertir objet DTO et objet domain)
       private static readonly MapperConfiguration _mapperConfiguration = new MapperConfiguration(cfg =>
       {
           cfg.AddProfile(new MappingProfile());
       });

       IMapper mapper = _mapperConfiguration.CreateMapper();

       
       
       
       
       
       //DAO
       
       
        
        [HttpGet]
        public ActionResult<IEnumerable<FicheDomain>> QueryAll()
        { 
            var temp = context.Fiches.ToList();
          List<FicheDomain> fiches = new List<FicheDomain>();
         foreach (Fiche f in temp)
          {
              var toAdd = mapper.Map<FicheDomain>(f);
              fiches.Add(toAdd);
          }
            return Ok(fiches);
        }
        
        [Authorize]
        [HttpGet]
        [Route("{pseudo}")]
        public ActionResult<IEnumerable<Fiche>> QueryAllByUser(string pseudo)
        {
            var fiches = context.Fiches
                .Where(f => f.IdJoueur == pseudo)
                .ToList();
            List<FicheDomain> ficheDomains = new List<FicheDomain>();
            foreach (Fiche f in fiches)
            {
                ficheDomains.Add(mapper.Map<FicheDomain>(f));
            }
            return Ok(ficheDomains);
        }

        [Authorize]
        [HttpGet]
        [Route("{pseudo}/{id}")]
        public ActionResult<FicheDomain> QueryById(string pseudo, int id)
        {
            var fiches = context.Fiches
                .FirstOrDefault(f => f.IdFiche == id && f.IdJoueur == pseudo);
            var ficheDomain = mapper.Map<FicheDomain>(fiches);
            return Ok(ficheDomain);
        }
        [Authorize]
        [HttpPost]
        public ActionResult<Fiche> Create(FicheDomain fiche)
        {
            var convert = mapper.Map<Fiche>(fiche);
            context.Fiches.Add(convert);
            return Ok(context.SaveChanges());
        }
        
        [Authorize]
        [HttpDelete]
        [Route("{id_fiche:int}")] //A définir
        public ActionResult Delete(int id_fiche)
        {
            var listFiche = context.Fiches
                .First(f => f.IdFiche == id_fiche);
           context.Remove<Fiche>(listFiche);
            return Ok(context.SaveChanges());
        }
        
        [Authorize]
        [HttpPut]
        [Route("{id_fiche:int}/{id_joueur}")] //A définir
        public ActionResult Put(int id_fiche, string id_joueur, [FromBody] FicheDomain fiche)
        {
            
            //Récupération de la fiche existante:
            var toModify = context.Fiches
                .First(f => f.IdFiche == id_fiche);
           // fiche.IdFiche = toModify.IdFiche;
            //Changement pour update
            mapper.Map<FicheDomain, Fiche>(fiche, toModify);
            //*******************************
            return Ok(context.SaveChanges());
                
            

            return NotFound();
        }

    }
}