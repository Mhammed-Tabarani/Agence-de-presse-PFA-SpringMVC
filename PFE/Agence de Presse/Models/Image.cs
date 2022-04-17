using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agence_de_Presse.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public byte[] PhotoFile { get; set; }
        public virtual Article Articles { get; set; }
    }
}