using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lfusa
    {
        public int Lfusaid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public int? SuNo { get; set; }
        public decimal? SuDia { get; set; }
        public decimal? SuDis { get; set; }
        public string? SidePanel { get; set; }
        public string? Japan { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
