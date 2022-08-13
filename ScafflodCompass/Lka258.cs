using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lka258
    {
        public int Lka258id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public string? LightType { get; set; }
        public string? Japan { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
