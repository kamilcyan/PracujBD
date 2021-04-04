using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class BussinesService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? PublicationTime { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
    }
}
