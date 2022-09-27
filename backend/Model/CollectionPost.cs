using System;
using System.Collections.Generic;

namespace Model
{
    public partial class CollectionPost
    {
        public int? CollectionId { get; set; }
        public int? PostId { get; set; }

        public virtual Collection? Collection { get; set; }
        public virtual Post? Post { get; set; }
    }
}
