using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class DrawingNumMatrix
    {
        public int DrawingId { get; set; }
        public string DrawingNum { get; set; } = null!;
        public string DrawingDesc { get; set; } = null!;
        public string DrawingType { get; set; } = null!;
        public string? Mark { get; set; }
        public DateTime? AddedDate { get; set; }
        public int UserId { get; set; }
        public string? DrawingImage { get; set; }
        public int? ProdPriority { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
