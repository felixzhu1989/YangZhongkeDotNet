using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ProjectsMarine
    {
        public ProjectsMarine()
        {
            DrawingPlanMarines = new HashSet<DrawingPlanMarine>();
            SpecialRequirementsMarines = new HashSet<SpecialRequirementsMarine>();
        }

        public int ProjectId { get; set; }
        public string Odpno { get; set; } = null!;
        public string? Bpono { get; set; }
        public string? ProjectName { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? ShippingTime { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? UserId { get; set; }
        public string? HoodType { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual User? User { get; set; }
        public virtual FinancialDataMarine FinancialDataMarine { get; set; } = null!;
        public virtual GeneralRequirementsMarine GeneralRequirementsMarine { get; set; } = null!;
        public virtual ProjectTrackingMarine ProjectTrackingMarine { get; set; } = null!;
        public virtual ICollection<DrawingPlanMarine> DrawingPlanMarines { get; set; }
        public virtual ICollection<SpecialRequirementsMarine> SpecialRequirementsMarines { get; set; }
    }
}
