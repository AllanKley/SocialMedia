using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Collection
    {
        public int Id { get; set; }
        public string CollectionName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Secret { get; set; }
        public int? UserId { get; set; }

        public virtual UserInfo? User { get; set; }
    }
}
