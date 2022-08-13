using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class DxfcutList
    {
        public int CutListId { get; set; }
        public int CategoryId { get; set; }
        public string? PartDescription { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Thickness { get; set; }
        public int? Quantity { get; set; }
        public string? Materials { get; set; }
        public string? PartNo { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
