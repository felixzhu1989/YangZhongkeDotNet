using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ProjectTracking
    {
        public int ProjectTrackingId { get; set; }
        public int ProjectId { get; set; }
        public int ProjectStatusId { get; set; }
        public DateTime? DrReleaseActual { get; set; }
        public DateTime? ProdFinishActual { get; set; }
        public DateTime? DeliverActual { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? OdpreceiveDate { get; set; }
        public DateTime? KickOffDate { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual ProjectStatus ProjectStatus { get; set; } = null!;
    }
}
