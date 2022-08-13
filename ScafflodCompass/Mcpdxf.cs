using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Mcpdxf
    {
        public int Mcpdxfid { get; set; }
        public int? ModuleTreeId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Length { get; set; }
        public decimal? Deepth { get; set; }
        public string? Height { get; set; }
        public string? SidePanel { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
