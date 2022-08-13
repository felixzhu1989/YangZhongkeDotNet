using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class CeilingCutList
    {
        public int CutListId { get; set; }
        public int SubAssyId { get; set; }
        public string? PartDescription { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Thickness { get; set; }
        public int? Quantity { get; set; }
        public string? Materials { get; set; }
        public string? PartNo { get; set; }
        public DateTime? AddedDate { get; set; }
        public int UserId { get; set; }

        public virtual SubAssy SubAssy { get; set; } = null!;
    }
}
