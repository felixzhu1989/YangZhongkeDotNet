using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class SpecialRequirementsMarine
    {
        public int SpecialRequirementId { get; set; }
        public int ProjectId { get; set; }
        public string? Content { get; set; }

        public virtual ProjectsMarine Project { get; set; } = null!;
    }
}
