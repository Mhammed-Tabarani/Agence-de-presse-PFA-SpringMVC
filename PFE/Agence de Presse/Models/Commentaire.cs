using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class Commentaire
    {
        public int CommentaireID { get; set; }
        public string Contenu { get; set; }
        public virtual Article Articles { get; set; }
        public virtual Lecteur Lecteur { get; set; }
    }
}