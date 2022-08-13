using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class QualityFeedback
    {
        public int QualityFeedbackId { get; set; }
        public int ProjectId { get; set; }
        public string? Content { get; set; }
        public DateTime? AddedDate { get; set; }
        public int UserId { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
