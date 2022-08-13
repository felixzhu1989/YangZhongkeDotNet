using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class SemiBom
    {
        public int SemiBomId { get; set; }
        public int ProjectId { get; set; }
        public string DrawingNum { get; set; } = null!;
        public int? Quantity { get; set; }

        public virtual Project Project { get; set; } = null!;
    }
}
