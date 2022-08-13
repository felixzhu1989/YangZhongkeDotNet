using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class FinancialDataMarine
    {
        public int FinancialDataId { get; set; }
        public int ProjectId { get; set; }
        public decimal? SalesValue { get; set; }

        public virtual ProjectsMarine Project { get; set; } = null!;
    }
}
