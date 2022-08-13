using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            Users = new HashSet<User>();
        }

        public int UserGroupId { get; set; }
        public string GroupName { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
