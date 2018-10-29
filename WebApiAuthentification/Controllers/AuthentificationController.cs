using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAuthentification.Models;

namespace WebApiAuthentification.Controllers
{
    [Produces("application/json")]
    [Route("api/Authentification")]
    public class AuthentificationController : Controller
    {
        //retourne une référence et que les écritures ne sont pas autorisées sur cette référence
        private readonly ApplicationDbContext context;
        public AuthentificationController(ApplicationDbContext context)
        {
            this.context = context;
        }
         
        //api/Authentification/email1/password 1 
        [HttpGet]
        public bool Authenticate(string email, string passWord)
        {
            if (email == null || passWord == null)
                return false;
            else
            {
                var cnx = context.Connexions.FirstOrDefault(x => x.email == email && x.passWord == passWord);
                if (cnx == null)
                    return false;
                else
                    return true;
            }
        }
    }
}