using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ProjectTypesMarine
    {
        public ProjectTypesMarine()
        {
            GeneralRequirementsMarines = new HashSet<GeneralRequirementsMarine>();
        }

        public int TypeId { get; set; }
        public string? TypeName { get; set; }
        public string? Kmlink { get; set; }

        public virtual ICollection<GeneralRequirementsMarine> GeneralRequirementsMarines { get; set; }
    }
}
