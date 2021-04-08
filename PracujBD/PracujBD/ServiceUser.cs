using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class ServiceUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string Adress { get; set; }
        public string PnoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? ExpectedSalary { get; set; }
        public string Experience { get; set; }
        public string Education { get; set; }
        public string Language { get; set; }
        public string Skills { get; set; }
        public string Certification { get; set; }
        public int? RecomendedOffertId { get; set; }
        public int? SavedOffertId { get; set; }
        public int? MyApplicationId { get; set; }
        public string Cv { get; set; }
        public int? MessageId { get; set; }
        public int? LevelOfLanguageId { get; set; }

        public virtual LevelOfLanguage LevelOfLanguage { get; set; }
        public virtual Message Message { get; set; }
        public virtual JobOffert MyApplication { get; set; }
        public virtual JobOffert RecomendedOffert { get; set; }
        public virtual JobOffert SavedOffert { get; set; }
    }
}
