﻿using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Cj330
    {
        public int Cj330id { get; set; }
        public int? ModuleTreeId { get; set; }
        public decimal? Length { get; set; }
        public string? SidePanel { get; set; }
        public string? SuType { get; set; }
        public decimal? SuDis { get; set; }
        public string? BackCjside { get; set; }
        public decimal? LeftDis { get; set; }
        public decimal? RightDis { get; set; }
        public string? LeftBeamType { get; set; }
        public decimal? LeftBeamDis { get; set; }
        public string? RightBeamType { get; set; }
        public decimal? RightBeamDis { get; set; }
        public string? Lkside { get; set; }
        public string? GutterSide { get; set; }
        public decimal? GutterWidth { get; set; }

        public virtual ModuleTree? ModuleTree { get; set; }
    }
}