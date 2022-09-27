using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Theme
    {
        public Theme()
        {
            UserInfos = new HashSet<UserInfo>();
        }

        public int Id { get; set; }
        public string? ThemeName { get; set; }

        public virtual ICollection<UserInfo> UserInfos { get; set; }
    }
}
