using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class CeilingPackingList
    {
        public int CeilingPackingListId { get; set; }
        public int ProjectId { get; set; }
        public string CeilingAccessoryId { get; set; } = null!;
        public int ClassNo { get; set; }
        public string? PartDescription { get; set; }
        public int? Quantity { get; set; }
        public string? PartNo { get; set; }
        public string? Unit { get; set; }
        public string? Length { get; set; }
        public string? Width { get; set; }
        public string? Height { get; set; }
        public string? Material { get; set; }
        public string? Remark { get; set; }
        public string? CountingRule { get; set; }
        public DateTime? AddedDate { get; set; }
        public int UserId { get; set; }
        public string? Location { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
