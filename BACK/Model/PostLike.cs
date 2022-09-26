using System;
using System.Collections.Generic;

namespace BACK.Model
{
    public partial class PostLike
    {
        public int? UserId { get; set; }
        public int? PostId { get; set; }

        public virtual Post? Post { get; set; }
        public virtual UserInfo? User { get; set; }
    }
}
