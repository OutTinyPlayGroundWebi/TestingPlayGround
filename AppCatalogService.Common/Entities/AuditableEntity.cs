using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalogService.Core.Common.Entities
{
    // This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)

    public class AuditableEntity : BaseEntity
    {
        //ToDo: needs more properties
        public DateTime CreateDate { get; set; }

        public DateTime? LastUpdateDate { get; set; }
    }
}
