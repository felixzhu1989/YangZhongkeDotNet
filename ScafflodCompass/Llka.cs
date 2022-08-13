using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Llka
    {
        public int Llkaid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public int? LongGlassNo { get; set; }
        public int? ShortGlassNo { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
