using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? LevelOfLanguageId { get; set; }
    }
}
