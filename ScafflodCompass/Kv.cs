using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Kv
    {
        public int Kvsid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Deepth { get; set; }
        public int? ExNo { get; set; }
        public decimal? ExDis { get; set; }
        public decimal? ExLength { get; set; }
        public decimal? ExWidth { get; set; }
        public decimal? ExHeight { get; set; }
        public string? LightType { get; set; }
        public string? SidePanel { get; set; }
        public string? Height { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
