using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Collection : Interfaces.IDataManipulation
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string CreationDate { get; set; }


        private List<int> CollectionPostIds { get; set; }
        private List<CollectionPost> CollectionPosts { get; set; }

        private int UserId { get; set; }
        private User User { get; set; }



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
