using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Hoodbcj
    {
        public int Hoodbcjid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Height { get; set; }
        public decimal? SuDis { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
