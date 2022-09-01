﻿using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ProjectLearned
    {
        public int ProjectLearnedId { get; set; }
        public int ProjectId { get; set; }
        public string? Content { get; set; }
        public DateTime? AddedDate { get; set; }
        public int UserId { get; set; }
        public string? Kmlink { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}