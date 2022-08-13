using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lfumc200susdxf
    {
        public int Lfumc200susdxfid { get; set; }
        public int? ModuleTreeId { get; set; }
        public int? Quantity { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
