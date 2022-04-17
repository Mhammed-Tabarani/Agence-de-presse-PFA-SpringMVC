using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class RedacteurEnChef
    {
        public int RedacteurEnChefID { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public string Nationalite { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public virtual Compte Compte { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}