using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class LevelOfLanguage
    {
        public LevelOfLanguage()
        {
            ServiceUsers = new HashSet<ServiceUser>();
        }

        public int Id { get; set; }
        public string Level { get; set; }

        public virtual ICollection<ServiceUser> ServiceUsers { get; set; }
    }
}
