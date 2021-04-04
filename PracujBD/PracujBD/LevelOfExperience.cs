using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class LevelOfExperience
    {
        public LevelOfExperience()
        {
            JobOfferts = new HashSet<JobOffert>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<JobOffert> JobOfferts { get; set; }
    }
}
