using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CollectionPost : Interfaces.IDataManipulation
    {
        private int CollectionId { get; set; }
        private Collection Collection { get; set; }

        private int PostId { get; set; }
        private Post Post { get; set; }







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
