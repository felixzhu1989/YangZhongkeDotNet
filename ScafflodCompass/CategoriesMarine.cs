using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class CategoriesMarine
    {
        public CategoriesMarine()
        {
            InverseParent = new HashSet<CategoriesMarine>();
            ModuleTreeMarines = new HashSet<ModuleTreeMarine>();
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

        public virtual CategoriesMarine Parent { get; set; } = null!;
        public virtual ICollection<CategoriesMarine> InverseParent { get; set; }
        public virtual ICollection<ModuleTreeMarine> ModuleTreeMarines { get; set; }
    }
}
