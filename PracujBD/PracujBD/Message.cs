using System;
using System.Collections.Generic;

#nullable disable

namespace PracujBD
{
    public partial class Message
    {
        public Message()
        {
            ServiceUsers = new HashSet<ServiceUser>();
        }

        public int Id { get; set; }
        public int? SenderId { get; set; }
        public string Body { get; set; }

        public virtual ICollection<ServiceUser> ServiceUsers { get; set; }
    }
}
