using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ProjectType
    {
        public ProjectType()
        {
            GeneralRequirements = new HashSet<GeneralRequirement>();
        }

        public int TypeId { get; set; }
        public string? TypeName { get; set; }
        public string? Kmlink { get; set; }

        public virtual ICollection<GeneralRequirement> GeneralRequirements { get; set; }
    }
}
