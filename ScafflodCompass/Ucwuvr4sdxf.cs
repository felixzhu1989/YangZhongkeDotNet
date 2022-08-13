using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Ucwuvr4sdxf
    {
        public int Ucwuvr4sdxfid { get; set; }
        public int? ModuleTreeId { get; set; }
        public int? Quantity { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
