using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class User
    {
        public User()
        {
            AfterSaleFeedbacks = new HashSet<AfterSaleFeedback>();
            CeilingPackingLists = new HashSet<CeilingPackingList>();
            CheckComments = new HashSet<CheckComment>();
            DrawingNumMatrices = new HashSet<DrawingNumMatrix>();
            ProjectLearneds = new HashSet<ProjectLearned>();
            Projects = new HashSet<Project>();
            ProjectsMarines = new HashSet<ProjectsMarine>();
            QualityFeedbacks = new HashSet<QualityFeedback>();
        }

        public int UserId { get; set; }
        public int UserGroupId { get; set; }
        public string UserAccount { get; set; } = null!;
        public string UserPwd { get; set; } = null!;
        public string? Email { get; set; }
        public string? Contact { get; set; }
        public string? EmailPwd { get; set; }

        public virtual UserGroup UserGroup { get; set; } = null!;
        public virtual ICollection<AfterSaleFeedback> AfterSaleFeedbacks { get; set; }
        public virtual ICollection<CeilingPackingList> CeilingPackingLists { get; set; }
        public virtual ICollection<CheckComment> CheckComments { get; set; }
        public virtual ICollection<DrawingNumMatrix> DrawingNumMatrices { get; set; }
        public virtual ICollection<ProjectLearned> ProjectLearneds { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<ProjectsMarine> ProjectsMarines { get; set; }
        public virtual ICollection<QualityFeedback> QualityFeedbacks { get; set; }
    }
}
