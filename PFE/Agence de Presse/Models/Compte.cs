using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class Compte
    {
        public int CompteID { get; set; }
        public int Email { get; set; }
        public int Password { get; set; }
        public bool IsBlocked { get; set; }
    }
}