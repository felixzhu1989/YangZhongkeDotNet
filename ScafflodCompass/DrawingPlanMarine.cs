using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class DrawingPlanMarine
    {
        public DrawingPlanMarine()
        {
            ModuleTreeMarines = new HashSet<ModuleTreeMarine>();
        }

        public int DrawingPlanId { get; set; }
        public int ProjectId { get; set; }
        public string? Item { get; set; }
        public string Model { get; set; } = null!;
        public int ModuleNo { get; set; }
        public DateTime? DrReleaseTarget { get; set; }
        public decimal? SubTotalWorkload { get; set; }
        public DateTime? AddedDate { get; set; }
        public string? LabelImage { get; set; }

        public virtual ProjectsMarine Project { get; set; } = null!;
        public virtual ICollection<ModuleTreeMarine> ModuleTreeMarines { get; set; }
    }
}
