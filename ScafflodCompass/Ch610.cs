using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Ch610
    {
        public int Ch610id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Deepth { get; set; }
        public string? Height { get; set; }
        public decimal? ExRightDis { get; set; }
        public int? ExNo { get; set; }
        public decimal? ExDis { get; set; }
        public decimal? ExLength { get; set; }
        public decimal? ExWidth { get; set; }
        public decimal? ExHeight { get; set; }
        public string? SidePanel { get; set; }
        public string? LightType { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
