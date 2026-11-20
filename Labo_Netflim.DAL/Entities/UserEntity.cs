using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.DAL.Entities
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public required string Pseudo {  get; set; }
        public required string LastName { get; set; }
        public required string FirstName {  get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public string Role { get; set; } = "User";
        public ICollection<InteractEntity> Interact { get; set; } = [];

    }
}
