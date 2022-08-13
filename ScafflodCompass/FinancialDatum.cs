using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class FinancialDatum
    {
        public int FinancialDataId { get; set; }
        public int ProjectId { get; set; }
        public decimal? SalesValue { get; set; }

        public virtual Project Project { get; set; } = null!;
    }
}
