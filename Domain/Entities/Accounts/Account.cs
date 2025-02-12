using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Accounts
{
    public class Account
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public string? Nationality { get; set; }
        public string? FamilyStatus { get; set; }
        public string? Phone { get; set; }
        public string? Photo { get; set; }
    }
}
