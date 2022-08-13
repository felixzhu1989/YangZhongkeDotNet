using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lledum
    {
        public int Lledaid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
