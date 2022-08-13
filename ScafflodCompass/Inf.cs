using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Inf
    {
        public int Infid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
