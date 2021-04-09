using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class TypeOfContract
    {
        public TypeOfContract()
        {
            JobOfferts = new HashSet<JobOffert>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<JobOffert> JobOfferts { get; set; }
    }
}
