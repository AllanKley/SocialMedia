using System;
using System.Collections.Generic;

namespace BACK.Model
{
    public partial class TagPost
    {
        public int? TagId { get; set; }
        public int? PostId { get; set; }

        public virtual Post? Post { get; set; }
        public virtual Tag? Tag { get; set; }
    }
}
