using System;
using System.Collections.Generic;

namespace ScafflodCompass
{
    public partial class Customer
    {
        public Customer()
        {
            Projects = new HashSet<Project>();
            ProjectsMarines = new HashSet<ProjectsMarine>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;

        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<ProjectsMarine> ProjectsMarines { get; set; }
    }
}
