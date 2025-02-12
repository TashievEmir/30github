using Domain.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTimeOffset Created { get; set; } = DateTime.Now;
        public string CreatedById { get; set; }
        public Account CreatedBy { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? UpdatedById { get; set; }
        public Account? UpdatedBy { get; set; }
    }
}
