using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class AdviceCategory
    {
        public AdviceCategory()
        {
            Advices = new HashSet<Advice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Advice> Advices { get; set; }
    }
}
