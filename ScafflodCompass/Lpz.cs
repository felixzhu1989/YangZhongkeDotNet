using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lpz
    {
        public int Lpzid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public int? ZpanelNo { get; set; }
        public decimal? Width { get; set; }
        public string? LightType { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
