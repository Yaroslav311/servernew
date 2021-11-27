using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_server.Access.Data.Core.Models
{
    public class UserRto
    {
        [Key] public int Id { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public int PhoneNumber { get; set; }
        public int Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string AvatarUrl { get; set; }
        public string Introduction { get; set; }
        public UserRoleRto Role { get; set; }

        [NotMapped]
        public string GetFullName
        {
            get => LastName + " " + FirstName + " " + Patronymic;
        }
    }
}
