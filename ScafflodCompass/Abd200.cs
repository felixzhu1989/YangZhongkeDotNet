﻿using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Abd200
    {
        public int Abd200id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Deepth { get; set; }
        public string? Height { get; set; }
        public string? SidePanel { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}
