using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.DAL.Entities
{
    public class PersonneEntity
    {
        public int PersonneId { get; set; }
        public required string Nom { get; set; }
        public required string Prenom { get; set; }

    }
}
