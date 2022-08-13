using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Bcj330
    {
        public int Bcj330id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public string? SidePanel { get; set; }
        public string? SuType { get; set; }
        public decimal? SuDis { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
