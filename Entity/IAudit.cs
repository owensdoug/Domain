using System;

namespace OwensDoug.Core.Entity
{
    public interface IAudit
    {
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ChangedOn { get; set; }
        public int ChangedBy { get; set; }
    }
}
