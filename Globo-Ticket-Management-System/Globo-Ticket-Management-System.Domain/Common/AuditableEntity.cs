using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo_Ticket_Management_System.Domain.Common
{
    public class AuditableEntity
    {
        public string ? CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public string ? LastModifiedBy { get; set; }
        
        public DateTime LastModifiedAt { get; set; }
    }
}
