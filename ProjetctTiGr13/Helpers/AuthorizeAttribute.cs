using System;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProjetctTiGr13.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //vérifie si il y a un User attaché a la requete, un User est attaché a la requete grace au JWTMiddleWare
            var user = (User) context.HttpContext.Items["User"];

            if (user == null)
            {
                // pas logged, envoie une reponse 401 Unauthorized
                context.Result = new JsonResult(new { message = "Unauthorized"}) {StatusCode = StatusCodes.Status401Unauthorized};
            }
            //sinon aucune action n'est prise et la réquete continue d'être passé au Controller
        }
    }
    
}