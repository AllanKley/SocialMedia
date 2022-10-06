using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Tag
    {
        public int Id { get; set; }
        public string? TagName { get; set; }

        public Tag(string tagName)
        {
            this.TagName = tagName;
        }
    }
}
