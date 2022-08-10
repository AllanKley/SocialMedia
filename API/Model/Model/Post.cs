using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Post : Interfaces.IDataManipulation
    {
        private int Id { get; set; }
        private string Picture { get; set; }
        private string Description { get; set; }
        private DateTime CreationDate { get; set; }


        private int UserId { get; set; }
        private User User { get; set; }

        private List<int> TagPostIds { get; set; }
        private List<TagPost> TagPosts { get; set; }








        public void delete()
        {
            throw new NotImplementedException();
        }

        public int save()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
