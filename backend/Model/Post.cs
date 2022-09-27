using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Post
    {
        public Post()
        {
            Pictures = new HashSet<Picture>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool? Comment { get; set; }
        public int? UserId { get; set; }

        public virtual UserInfo? User { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
