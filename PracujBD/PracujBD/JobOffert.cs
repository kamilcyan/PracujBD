using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class JobOffert
    {
        public JobOffert()
        {
            ServiceUsers = new HashSet<ServiceUser>();
        }

        public int Id { get; set; }
        public string Workplace { get; set; }
        public int? TypeOfContractId { get; set; }
        public string CompanyName { get; set; }
        public int? LevelOfExperienceId { get; set; }
        public string Post { get; set; }
        public string Requirements { get; set; }
        public string NiceToHave { get; set; }
        public string Responsabilities { get; set; }
        public string WePropose { get; set; }
        public string JobDescription { get; set; }

        public virtual LevelOfExperience LevelOfExperience { get; set; }
        public virtual TypeOfContract TypeOfContract { get; set; }
        public virtual ICollection<ServiceUser> ServiceUsers { get; set; }
    }
}
