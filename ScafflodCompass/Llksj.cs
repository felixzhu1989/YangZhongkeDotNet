using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Llksj
    {
        public int Llksjid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public int? LongGlassNo { get; set; }
        public int? ShortGlassNo { get; set; }
        public decimal? LeftLength { get; set; }
        public decimal? RightLength { get; set; }
        public decimal? MidLength { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
