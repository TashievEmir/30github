using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.References
{
    public class Reference : BaseEntity
    {
        public string Code { get; set; }
        public string NameKg { get; set; }
        public string NameRu { get; set; }
        public long? ParentReferenceId { get; set; }
        public Reference? ParentReference { get; set; }
    }
}
