using Labo_Netflim.BLL.Models;
using Labo_Netflim.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.BLL.Mappers
{
    internal static class PersonneMapper
    {
        public static PersonneModel ToModel(this PersonneEntity data)
        {
            return new PersonneModel()
            {
                Id = data.PersonneId,
                Prenom = data.Prenom,
                Nom = data.Nom
            };
        }
    }
}
