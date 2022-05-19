using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class InboxUser
    {
        public InboxUser()
        {
            MessageSentFromNavigations = new HashSet<Message>();
            MessageSentToNavigations = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Branch { get; set; }

        public virtual ICollection<Message> MessageSentFromNavigations { get; set; }
        public virtual ICollection<Message> MessageSentToNavigations { get; set; }
    }
}
