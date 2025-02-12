using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Accounts
{
    public class User
    {
        public int Id { get; set; }
        public string Email {  get; set; }
        public string PasswordHash { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
