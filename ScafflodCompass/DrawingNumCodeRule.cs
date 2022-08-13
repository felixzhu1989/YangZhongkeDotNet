using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class DrawingNumCodeRule
    {
        public DrawingNumCodeRule()
        {
            InverseParent = new HashSet<DrawingNumCodeRule>();
        }

        public int CodeId { get; set; }
        public int ParentId { get; set; }
        public string Code { get; set; } = null!;
        public string CodeName { get; set; } = null!;

        public virtual DrawingNumCodeRule Parent { get; set; } = null!;
        public virtual ICollection<DrawingNumCodeRule> InverseParent { get; set; }
    }
}
