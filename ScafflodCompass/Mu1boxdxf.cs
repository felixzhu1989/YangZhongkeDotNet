using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Mu1boxdxf
    {
        public int Mu1boxdxfid { get; set; }
        public int? ModuleTreeId { get; set; }
        public int? Quantity { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
