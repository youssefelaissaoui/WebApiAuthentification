using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAuthentification.Models
{
    public class Connexion
    {
        public int id { get; set; }
        public string email { get; set; }
        public string passWord { get; set; }
    }
}
