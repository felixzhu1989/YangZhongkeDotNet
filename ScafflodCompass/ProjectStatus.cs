using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ProjectStatus
    {
        public ProjectStatus()
        {
            ProjectTrackingMarines = new HashSet<ProjectTrackingMarine>();
            ProjectTrackings = new HashSet<ProjectTracking>();
        }

        public int ProjectStatusId { get; set; }
        public string ProjectStatusName { get; set; } = null!;
        public string? StatusDesc { get; set; }

        public virtual ICollection<ProjectTrackingMarine> ProjectTrackingMarines { get; set; }
        public virtual ICollection<ProjectTracking> ProjectTrackings { get; set; }
    }
}
