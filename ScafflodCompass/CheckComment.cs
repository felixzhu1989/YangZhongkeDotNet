using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class CheckComment
    {
        public int CheckCommentId { get; set; }
        public int ProjectId { get; set; }
        public string? Content { get; set; }
        public int CheckStatus { get; set; }
        public DateTime? AddedDate { get; set; }
        public int UserId { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
