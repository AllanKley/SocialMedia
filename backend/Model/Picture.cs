using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Picture
    {
        public int Id { get; set; }
        public byte[]? PictureString { get; set; }
        public int? PostId { get; set; }

        public virtual Post? Post { get; set; }
    }
}
