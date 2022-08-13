using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class GeneralRequirement
    {
        public int GeneralRequirementId { get; set; }
        public int ProjectId { get; set; }
        public int TypeId { get; set; }
        public string? InputPower { get; set; }
        public string? Marvel { get; set; }
        public string? AnsulprePipe { get; set; }
        public string? Ansulsystem { get; set; }
        public int? RiskLevel { get; set; }
        public string? MainAssyPath { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual ProjectType Type { get; set; } = null!;
    }
}
