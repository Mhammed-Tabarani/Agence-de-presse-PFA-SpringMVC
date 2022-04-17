using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class Administrateur
    {
        public int AdministrateurID { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public string Nationalite { get; set; }
        public string Email { get; set; }

        public string Adresse { get; set; }
        public virtual Compte Compte { get; set; }
    }
}