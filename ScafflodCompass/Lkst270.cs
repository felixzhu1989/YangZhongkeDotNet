using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lkst270
    {
        public int Lkst270id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public string? Wbeam { get; set; }
        public string? SidePanel { get; set; }
        public string? LightType { get; set; }
        public string? Japan { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
