using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class SuivreJournaliste
    {
        public int SuivreJournalisteID { get; set; }
        public string NomSujet { get; set; }
        public virtual Journaliste Journalistes { get; set; }
        public virtual Lecteur Lecteurs { get; set; }
    }
}