using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class GeneralRequirementsMarine
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

        public virtual ProjectsMarine Project { get; set; } = null!;
        public virtual ProjectTypesMarine Type { get; set; } = null!;
    }
}
