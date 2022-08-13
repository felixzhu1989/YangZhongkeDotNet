using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Project
    {
        public Project()
        {
            AfterSaleFeedbacks = new HashSet<AfterSaleFeedback>();
            CeilingPackingLists = new HashSet<CeilingPackingList>();
            CheckComments = new HashSet<CheckComment>();
            DrawingPlans = new HashSet<DrawingPlan>();
            ProjectLearneds = new HashSet<ProjectLearned>();
            QualityFeedbacks = new HashSet<QualityFeedback>();
            SemiBoms = new HashSet<SemiBom>();
            SpecialRequirements = new HashSet<SpecialRequirement>();
            SubAssies = new HashSet<SubAssy>();
        }

        public int ProjectId { get; set; }
        public string Odpno { get; set; } = null!;
        public string? Bpono { get; set; }
        public string? ProjectName { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? ShippingTime { get; set; }
        public DateTime? AddedDate { get; set; }
        public int UserId { get; set; }
        public string? HoodType { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual FinancialDatum FinancialDatum { get; set; } = null!;
        public virtual GeneralRequirement GeneralRequirement { get; set; } = null!;
        public virtual ProjectTracking ProjectTracking { get; set; } = null!;
        public virtual ICollection<AfterSaleFeedback> AfterSaleFeedbacks { get; set; }
        public virtual ICollection<CeilingPackingList> CeilingPackingLists { get; set; }
        public virtual ICollection<CheckComment> CheckComments { get; set; }
        public virtual ICollection<DrawingPlan> DrawingPlans { get; set; }
        public virtual ICollection<ProjectLearned> ProjectLearneds { get; set; }
        public virtual ICollection<QualityFeedback> QualityFeedbacks { get; set; }
        public virtual ICollection<SemiBom> SemiBoms { get; set; }
        public virtual ICollection<SpecialRequirement> SpecialRequirements { get; set; }
        public virtual ICollection<SubAssy> SubAssies { get; set; }
    }
}
