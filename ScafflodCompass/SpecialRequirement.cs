using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class SpecialRequirement
    {
        public int SpecialRequirementId { get; set; }
        public int ProjectId { get; set; }
        public string? Content { get; set; }

        public virtual Project Project { get; set; } = null!;
    }
}
