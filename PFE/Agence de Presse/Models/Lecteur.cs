using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class Lecteur
    {
        public int LecteurID { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public string Email { get; set; }
        public virtual Compte Compte { get; set; }
        public virtual ICollection<SuivreJournaliste> SuivreJournalistes { get; set; }
        public virtual ICollection<Commentaire> Commentaires { get; set; }
    }
}