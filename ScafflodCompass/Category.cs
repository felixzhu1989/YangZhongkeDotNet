using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Category
    {
        public Category()
        {
            DxfcutLists = new HashSet<DxfcutList>();
            InverseParent = new HashSet<Category>();
            ModuleTrees = new HashSet<ModuleTree>();
        }

        public int CategoryId { get; set; }
        public int ParentId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? CategoryDesc { get; set; }
        public string? Model { get; set; }
        public string? SubType { get; set; }
        public string? ModelImage { get; set; }
        public string? LastSaved { get; set; }
        public string? Kmlink { get; set; }
        public string? ModelPath { get; set; }

        public virtual Category Parent { get; set; } = null!;
        public virtual ICollection<DxfcutList> DxfcutLists { get; set; }
        public virtual ICollection<Category> InverseParent { get; set; }
        public virtual ICollection<ModuleTree> ModuleTrees { get; set; }
    }
}
