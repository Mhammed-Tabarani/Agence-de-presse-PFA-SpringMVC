using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class Sujet
    {
        public int SujetID { get; set; }
        public string NomSujet { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}