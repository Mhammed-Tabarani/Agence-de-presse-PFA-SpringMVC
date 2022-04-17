using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public virtual Journaliste Journaliste { get; set; }
        public virtual RedacteurEnChef RedacteurEnChef { get; set; }
        public virtual Sujet Sujet { get; set; }
        public virtual ICollection<Commentaire> Commentaires { get; set; }
        public virtual ICollection<Image> Images { get; set; }


    }
}