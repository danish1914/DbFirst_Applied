using System;
using System.Collections.Generic;

namespace DbFirst_Applied.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? SentTo { get; set; }
        public int? SentFrom { get; set; }

        public virtual InboxUser? SentFromNavigation { get; set; }
        public virtual InboxUser? SentToNavigation { get; set; }
    }
}
