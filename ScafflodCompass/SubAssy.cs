using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class SubAssy
    {
        public SubAssy()
        {
            CeilingCutLists = new HashSet<CeilingCutList>();
        }

        public int SubAssyId { get; set; }
        public int ProjectId { get; set; }
        public string? SubAssyName { get; set; }
        public string? SubAssyPath { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual ICollection<CeilingCutList> CeilingCutLists { get; set; }
    }
}
