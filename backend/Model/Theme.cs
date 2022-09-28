using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Theme
    {
        public Theme()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? ThemeName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
