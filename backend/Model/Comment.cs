using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Comment
    {
        public int? CommentId { get; set; }
        public int? PostId { get; set; }

        public virtual Post? CommentNavigation { get; set; }
        public virtual Post? Post { get; set; }
    }
}
