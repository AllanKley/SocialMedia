using System;
using System.Collections.Generic;

namespace Model
{
    public partial class UserUser
    {
        public int? UserFollowingId { get; set; }
        public int? UserFollowedId { get; set; }

        public virtual UserInfo? UserFollowed { get; set; }
        public virtual UserInfo? UserFollowing { get; set; }
    }
}
