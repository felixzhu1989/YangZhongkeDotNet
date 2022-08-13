using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lks270hcl
    {
        public int Lks270hclid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public string? Hclside { get; set; }
        public decimal? HclsideLeft { get; set; }
        public decimal? HclsideRight { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
