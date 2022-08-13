using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Bf200
    {
        public int Bf200id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? LeftLength { get; set; }
        public decimal? RightLength { get; set; }
        public decimal? MpanelLength { get; set; }
        public decimal? WpanelLength { get; set; }
        public int? MpanelNo { get; set; }
        public string? Uvtype { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
