using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class ViewDelayQuery
    {
        public int ProjectId { get; set; }
        public DateTime? Drtarget { get; set; }
        public DateTime? DrActual { get; set; }
    }
}
