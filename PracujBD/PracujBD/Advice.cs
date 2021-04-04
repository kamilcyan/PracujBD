using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class Advice
    {
        public int Id { get; set; }
        public int? AdviceCategoryId { get; set; }
        public string Subject { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Body { get; set; }

        public virtual AdviceCategory AdviceCategory { get; set; }
    }
}
