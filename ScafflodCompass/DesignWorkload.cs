﻿using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class DesignWorkload
    {
        public int WorkloadId { get; set; }
        public string? Model { get; set; }
        public decimal? WorkloadValue { get; set; }
        public string? ModelDesc { get; set; }
    }
}