using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : Interfaces.IDataManipulation
    {
     
        private int Id { get; set; }
        private string Name { get; set; }
        private string UserName {get;set;}
        private string Password { get; set; }
        private string Email { get; set; }
        private DateTime Birthday { get; set; }
        private string ProfilePic { get; set; }
        private string CoverPic { get; set; }
        private string About { get; set; }
        private DateTime CreationDate { get; set; }

        private int ThemeId { get; set; }
        private Theme Theme { get; set; }






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
