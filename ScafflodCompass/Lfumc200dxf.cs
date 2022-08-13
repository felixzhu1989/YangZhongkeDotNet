using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lfumc200dxf
    {
        public int Lfumc200dxfid { get; set; }
        public int? ModuleTreeId { get; set; }
        public int? Quantity { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
