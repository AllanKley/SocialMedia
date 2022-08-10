using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Theme : Interfaces.IDataManipulation
    {
        private int Id { get; set; }
        private string Name { get; set; }


        private List<int> UserIds { get; set; }
        private List<User> Users { get; set; }


     

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
