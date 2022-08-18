using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRelation.OneMany
{
    public class Leave
    {
        public long Id { get; set; }
        public string Remarks { get; set; }

        public User Requester { get; set; }//申请人
        public User? Approver { get; set; } //审批人，注意标记可空
    }
}
