using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ModuleTreeMarine
    {
        public ModuleTreeMarine()
        {
            Hmes = new HashSet<Hme>();
            Hmfs = new HashSet<Hmf>();
            Hmms = new HashSet<Hmm>();
        }

        public int ModuleTreeId { get; set; }
        public int DrawingPlanId { get; set; }
        public int CategoryId { get; set; }
        public string Module { get; set; } = null!;

        public virtual CategoriesMarine Category { get; set; } = null!;
        public virtual DrawingPlanMarine DrawingPlan { get; set; } = null!;
        public virtual ICollection<Hme> Hmes { get; set; }
        public virtual ICollection<Hmf> Hmfs { get; set; }
        public virtual ICollection<Hmm> Hmms { get; set; }
    }
}
