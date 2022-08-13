using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Lsdost
    {
        public int Lsdostid { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public int? SuNo { get; set; }
        public decimal? SuDis { get; set; }
        public decimal? Deepth { get; set; }
        public string? SidePanel { get; set; }
        public string? Height { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
