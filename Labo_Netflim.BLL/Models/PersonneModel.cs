using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.BLL.Models
{
    public class PersonneModel
    {
        public int Id { get; set; }
        public required string Prenom { get; set; }
        public required string Nom { get; set; }
    }

}
